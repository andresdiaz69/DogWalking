namespace ECI.DogWalking.Forms.Walks
{
    using ECI.BusinessContracts.IServices;
    using ECI.Common.Core.MessagesApp;
    using ECI.DogWalking.Forms.Shared;
    using ECI.DogWalking.Forms.Shared.Menu;
    using ECI.Entities.Entities;
    using System.Windows.Forms;

    public partial class WalksForm : BaseForm
    {
        private readonly IWalkService _walkService;
        private readonly IClientService _clientService;
        private readonly IDogService _dogService;
        public long walkId { get; set; }

        public WalksForm(IFormNavigator navigator,
                         IWalkService walkService,
                         IClientService clientService,
                         IDogService dogService)
                           : base(navigator)
        {
            _walkService = walkService;
            _clientService = clientService;
            _dogService = dogService;
            InitializeComponent();
        }

        #region "Events"   
        private void WalksForm_Load(object sender, EventArgs e)
        {
            GetAllWalks();
            GetClients();
            FillFilters();
            ClearWalkForm();
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClient.SelectedIndex > 0)
            {
                long clientId = long.Parse(cbClient.SelectedValue.ToString());
                GetDogsByClient(clientId);
            }
            else
            {
                cbDog.DataSource = null;
                cbDog.Items.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearWalkForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    var walk = GetWalkData();

                    if (walkId == 0)
                        _walkService.SaveWalk(walk);
                    else
                        _walkService.UpdateWalk(walk);

                    ClearWalkForm();
                    GetAllWalks();
                    MessageBox.Show(MsgGeneral.MsgWalkSaved);

                }
                catch (Exception)
                {
                    MessageBox.Show(MsgGeneral.MsgGeneralError);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllWalks();
        }

        private void dgWalks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                walkId = Convert.ToInt64(dgWalks.Rows[dgWalks.CurrentRow.Index].Cells[0].Value);
                SetWalkInfo(walkId);
            }
        }
        #endregion


        #region "Methods"   
        private void GetAllWalks()
        {
            try
            {
                var listWalks = _walkService.GetAllWalks();

                if (cbFilters.SelectedIndex > 0)
                {
                    listWalks = listWalks.Where(w =>
                    (cbFilters.SelectedIndex == 1
                    && w.Dog.Client.Name.Contains(txtSearch.Text)) ||

                    (cbFilters.SelectedIndex == 2
                    && w.Dog.Name.Contains(txtSearch.Text))
                    ).ToList();
                }

                dgWalks.DataSource = listWalks;
                dgWalks.Columns["Id"].Visible = false;
                dgWalks.Columns["DogId"].Visible = false;
                dgWalks.Columns["Dog"].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show(MsgGeneral.MsgGeneralError);
            }
        }

        private void GetClients()
        {
            try
            {
                var listClients = _clientService.GetAllCLients(true);
                cbClient.DataSource = listClients;
                cbClient.DisplayMember = "Name";
                cbClient.ValueMember = "Id";
            }
            catch (Exception)
            {
                MessageBox.Show(MsgGeneral.MsgGeneralError);
            }
        }

        private void FillFilters()
        {
            cbFilters.Items.Clear();

            cbFilters.Items.Insert(0, "All walks");
            cbFilters.Items.Insert(1, "Client Name");
            cbFilters.Items.Insert(2, "Dog Name");
        }

        private void ClearWalkForm()
        {
            walkId = 0;
            errorsWalk.Clear();
            dtpDateWalk.Value = DateTime.Now;
            nudDurationWalk.Value = 1;
            cbClient.SelectedIndex = -1;
            cbDog.DataSource = null;
            cbDog.Items.Clear();
        }

        private void GetDogsByClient(long clientId)
        {
            try
            {
                var listDogs = _dogService.GetAllDogsByClientId(clientId);
                cbDog.DataSource = listDogs;
                cbDog.DisplayMember = "Name";
                cbDog.ValueMember = "Id";
            }
            catch (Exception)
            {
                MessageBox.Show(MsgGeneral.MsgGeneralError);
            }
        }

        private void SetWalkInfo(long walkId)
        {
            try
            {
                var walkInfo = _walkService.GetWalk(walkId);

                if (walkInfo is not null)
                {
                    dtpDateWalk.Value = walkInfo.Date;
                    nudDurationWalk.Value = (decimal)walkInfo.Duration.TotalMinutes;
                    cbClient.SelectedValue = walkInfo.Dog.Client.Id;
                    cbClients_SelectedIndexChanged(null, null);
                    cbDog.SelectedValue = walkInfo.DogId;
                }

            }
            catch (Exception)
            {
                MessageBox.Show(MsgGeneral.MsgGeneralError);
            }
        }

        private Walk GetWalkData()
        {
            return new Walk()
            {
                Id = walkId,
                Duration = new TimeSpan(0, (int)nudDurationWalk.Value, 0),
                Date = dtpDateWalk.Value,
                DogId = long.Parse(cbDog.SelectedValue.ToString())
            };
        }

        private bool ValidateFields()
        {
            bool formIsValid = true;
            errorsWalk.Clear();

            if (cbClient.SelectedIndex == -1)
            {
                errorsWalk.SetError(cbClient, MsgValidation.MsgClientNotSelected);
                formIsValid = false;
            }

            if (cbDog.SelectedIndex == -1)
            {
                errorsWalk.SetError(cbDog, MsgValidation.MsgDogNotSelected);
                formIsValid = false;
            }

            return formIsValid;
        }
        #endregion

    }
}
