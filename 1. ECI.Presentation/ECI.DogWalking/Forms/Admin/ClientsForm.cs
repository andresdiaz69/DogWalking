namespace ECI.DogWalking.Forms.Admin
{
    using ECI.BusinessContracts.IServices;
    using ECI.Common.Core.MessagesApp;
    using ECI.DogWalking.Forms.Shared;
    using ECI.DogWalking.Forms.Shared.Menu;
    using ECI.Entities.Entities;
    using System;
    using System.Windows.Forms;

    public partial class ClientsForm : BaseForm
    {
        public long clientId { get; set; }
        private readonly IClientService _clientService;
        private readonly IFormNavigator _navigator;

        public ClientsForm(IFormNavigator navigator,
                           IClientService clientService)
                           : base(navigator)
        {
            _clientService = clientService;
            _navigator = navigator;
            InitializeComponent();
        }

        protected ClientsForm() : base() { }

        #region "Events"       
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            GetAllClients();
            FillFilters();
            ClearClientForm();
        }

        private void dgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clientId = Convert.ToInt64(dgClients.Rows[dgClients.CurrentRow.Index].Cells[0].Value);
                SetClientInfo(clientId);
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFilters.SelectedIndex;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllClients();
        }

        private void btnAddDogs_Click(object sender, EventArgs e)
        {
            _navigator.OpenClientDogs(clientId);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearClientForm();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    var client = GetClientData();

                    if (clientId == 0)
                        _clientService.SaveClient(client);
                    else
                        _clientService.UpdateClient(client);

                    ClearClientForm();
                    GetAllClients();
                    MessageBox.Show(MsgGeneral.MsgClientSaved);
                }
                catch (Exception)
                {
                    MessageBox.Show(MsgGeneral.MsgGeneralError);
                }
            }
        }
        #endregion

        #region "Methods"
        private void GetAllClients()
        {
            try
            {
                var listClients = _clientService.GetAllCLients(false);

                if (cbFilters.SelectedIndex > 0)
                {
                    listClients = listClients.Where(c =>
                    (cbFilters.SelectedIndex == 1 && c.Name.Contains(txtSearch.Text)) ||
                    (cbFilters.SelectedIndex == 2 && c.LastName.Contains(txtSearch.Text))
                    ).ToList();
                }

                dgClients.DataSource = listClients;
                dgClients.Columns["Id"].Visible = false;
                dgClients.Columns["Dogs"].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show(MsgGeneral.MsgGeneralError);
            }
        }

        private void FillFilters()
        {
            cbFilters.Items.Clear();

            cbFilters.Items.Insert(0, "All clients");
            cbFilters.Items.Insert(1, "Name");
            cbFilters.Items.Insert(2, "Last Name");
        }

        private void ClearClientForm()
        {
            txtName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            chActive.Checked = true;
            chActive.Enabled = false;
            clientId = 0;
            btnAddDogs.Enabled = false;
            btnAdd.Text = "Add new";
            errorsClient.Clear();
        }

        private void SetClientInfo(long clientId)
        {
            try
            {
                var clientInfo = _clientService.GetClient(clientId);

                if (clientInfo is not null)
                {
                    txtName.Text = clientInfo.Name;
                    txtLastName.Text = clientInfo.LastName;
                    txtPhone.Text = clientInfo.PhoneNumber.ToString();
                    chActive.Checked = clientInfo.isActive;
                    chActive.Enabled = true;
                    btnAddDogs.Enabled = true;
                    btnAdd.Text = "Update";
                }
            }
            catch (Exception)
            {
                MessageBox.Show(MsgGeneral.MsgGeneralError);
            }
        }

        private bool ValidateFields()
        {
            bool formIsValid = true;
            errorsClient.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorsClient.SetError(txtName, MsgValidation.MsgClientNameEmpty);
                formIsValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorsClient.SetError(txtLastName, MsgValidation.MsgClientLastNameEmpty);
                formIsValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorsClient.SetError(txtPhone, MsgValidation.MsgClientPhoneEmpty);
                formIsValid = false;
            }

            if (!ECI.Common.Core.Utils.ValidateFields.isNumber(txtPhone.Text))
            {
                errorsClient.SetError(txtPhone, MsgValidation.MsgClientPhoneNotNumber);
                formIsValid = false;
            }

            return formIsValid;
        }

        private Client GetClientData()
        {
            return new Client()
            {
                Id = clientId,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = int.Parse(txtPhone.Text),
                isActive = chActive.Checked
            };
        }
        #endregion
    }
}