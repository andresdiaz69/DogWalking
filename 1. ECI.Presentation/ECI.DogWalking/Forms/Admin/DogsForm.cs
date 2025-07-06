namespace ECI.DogWalking.Forms.Admin
{
    using ECI.Common.Core.MessagesApp;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using System;
    using System.Windows.Forms;

    public partial class DogsForm : Form
    {
        private readonly IDogRepostory _dogRepostory;
        private readonly IBreedRepository _breedRepository;

        public DogsForm(//IFormNavigator navigator,
                        IBreedRepository breedRepository,
                        IDogRepostory dogRepostory)
        {
            _breedRepository = breedRepository;
            _dogRepostory = dogRepostory;
            InitializeComponent();
        }

        #region "Events"
        private void DogsForm_Load(object sender, EventArgs e)
        {
            GetBreeds();
            ClearDogsForm();
        }
        #endregion

        #region "Methods"
        public void GetDogsByClient(long clientId)
        {
            try
            {
                var listDogs = _dogRepostory.GetAllDogsByClientId(clientId);

                dgDogs.DataSource = listDogs;
                dgDogs.Columns["ClientId"].Visible = false;
                dgDogs.Columns["BreedId"].Visible = false;                

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
                var breedList = _breedRepository.GetAllBreeds();

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
        }

        private Dog GetDogData()
        {
            //return new Dog()
            //{
            //    Name = txtName.Text,
            //    BreedId = int.Parse(cbBreed.SelectedItem.ToString()),
            //    Age = (short)nudAge.Value,
            //    Id =0                
            //};

            return null;
        }
        #endregion
    }
}
