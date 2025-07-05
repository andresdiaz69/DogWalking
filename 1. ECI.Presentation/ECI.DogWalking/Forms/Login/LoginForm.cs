namespace ECI.DogWalking
{
    using ECI.BusinessContracts.IServices;
    using ECI.Common.Core.MessagesApp;
    using ECI.Common.Core.Utils;
    using ECI.DogWalking.Forms.Shared;
    using ECI.Entities;
    using ECI.Entities.DTO;

    public partial class LoginForm : Form
    {
        private readonly ILoginService _loginService;

        public LoginForm(ILoginService loginService)
        {
            InitializeComponent();
            this._loginService = loginService;
        }

        #region "Events"       
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var validUser = await _loginService.ValidateUser(
                    new LoginDTO()
                    {
                        Email = txtEmail.Text,
                        Password = Encrypt.EncryptToMD5(txtPassword.Text)
                    });

                if (validUser is not null)
                {
                    var baseForm = new BaseForm();
                    baseForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show(MsgValidation.MsgLoginUserNotValid, "Error");
            }
        }
        #endregion

        #region "Methods"
        private bool ValidateFields()
        {
            bool formIsValid = true;

            errorsLogin.Clear();

            if (!ECI.Common.Core.Utils.ValidateFields.isValidEmail(txtEmail.Text))
            {
                errorsLogin.SetError(txtEmail, MsgValidation.MsgLoginEmailNotValid);
                formIsValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorsLogin.SetError(txtEmail, MsgValidation.MsgLoginEmailEmpty);
                formIsValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorsLogin.SetError(txtPassword, MsgValidation.MsgLoginPasswordEmpty);
                formIsValid = false;
            }

            return formIsValid;
        }
        #endregion
    }
}
