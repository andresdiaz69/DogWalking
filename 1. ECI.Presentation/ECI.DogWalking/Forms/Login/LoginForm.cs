namespace ECI.DogWalking
{
    using ECI.BusinessContracts.IServices;
    using ECI.Common.Core.MessagesApp;
    using ECI.Common.Core.Utils;
    using ECI.DogWalking.Forms.Admin;
    using ECI.DogWalking.Forms.Shared;
    using ECI.DogWalking.Forms.Walks;
    using ECI.Entities.DTO;
    using Microsoft.Extensions.DependencyInjection;

    public partial class LoginForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILoginService _loginService;

        public LoginForm(IServiceProvider serviceProvider, 
                         ILoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
            _serviceProvider = serviceProvider;

            // temp
            txtEmail.Text = "admin@eci.com";
            txtPassword.Text = "admin";
        }

        #region "Events"       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    var validUser = _loginService.ValidateUser(
                        new LoginDTO()
                        {
                            Email = txtEmail.Text,
                            Password = Encrypt.EncryptToMD5(txtPassword.Text)
                        });

                    if (validUser is not null)
                    {
                        var mainForm = _serviceProvider.GetRequiredService<WalksForm>();
                        //mainForm.SetUserName($"{validUser.Name} {validUser.LastName}");
                        mainForm.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show(MsgValidation.MsgLoginUserNotValid, "Error");
                }
                catch (Exception)
                {
                    MessageBox.Show(MsgGeneral.MsgGeneralError);
                }
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
