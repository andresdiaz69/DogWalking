namespace ECI.DogWalking.Forms.Admin
{
    using ECI.BusinessContracts.IServices;
    using ECI.Common.Core.MessagesApp;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using System;
    using System.Windows.Forms;

    public partial class DogsForm : Form
    {
        public long clientId { get; set; }
        private readonly IDogService _dogService;
        private readonly IBreedService _breedService;

        public DogsForm(IDogService dogService,
                        IBreedService breedService)
        {
            _breedService = breedService;
            _dogService = dogService;

            InitializeComponent();            
        }

        #region "Events"
        private void DogsForm_Load(object sender, EventArgs e)
        {
            GetBreeds();
            ClearDogsForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDogsForm();
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    var dog = GetDogData();

                    _dogService.SaveDog(dog);

                    ClearDogsForm();
                    GetDogsByClient(clientId);
                    MessageBox.Show(MsgGeneral.MsgDogSaved);
                }
                catch (Exception)
                {
                    MessageBox.Show(MsgGeneral.MsgGeneralError);
                }
            }
        }
        #endregion

        #region "Methods"
        public void GetDogsByClient(long clientId)
        {
            try
            {
                var listDogs = _dogService.GetAllDogsByClientId(clientId);

                dgDogs.DataSource = listDogs;
                dgDogs.Columns["Id"].Visible = false;
                dgDogs.Columns["ClientId"].Visible = false;
                dgDogs.Columns["BreedId"].Visible = false;
                dgDogs.Columns["Client"].Visible = false;
                dgDogs.Columns["Breed"].Visible = false;
                dgDogs.Columns["Walks"].Visible = false;
                dgDogs.Columns["isActive"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgGeneral.MsgGeneralError);
            }
        }

        private void GetBreeds()
        {
            try
            {
                var breedList = _breedService.GetAllBreeds();

                cbBreed.DataSource = breedList;
                cbBreed.DisplayMember = "Name";
                cbBreed.ValueMember = "Id";
            }
            catch (Exception)
            {
                MessageBox.Show(MsgGeneral.MsgGeneralError);
            }
        }

        private void ClearDogsForm()
        {
            txtName.Text = string.Empty;
            nudAge.Value = 0;
            cbBreed.SelectedIndex = -1;
            errorsDogs.Clear();
        }

        public bool ValidateFields() 
        {

            bool formIsValid = true;
            errorsDogs.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorsDogs.SetError(txtName, MsgValidation.MsgDogNameEmpty);
                formIsValid = false;
            }

            if (cbBreed.SelectedIndex == -1)
            {
                errorsDogs.SetError(cbBreed, MsgValidation.MsgBreedNotSelected);
                formIsValid = false;
            }


            return formIsValid;
        }

        private Dog GetDogData()
        {
            return new Dog()
            {
                Name = txtName.Text,
                BreedId = int.Parse(cbBreed.SelectedValue.ToString()),
                Age = (short)nudAge.Value,
                Id = 0,
                ClientId = clientId,
                isActive = true
            };

            return null;
        }
        #endregion
    }
}
