namespace ECI.BusinessServices.Services
{
    using ECI.BusinessContracts.IServices;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.DTO;
    using ECI.Entities.Entities;

    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        /// <summary>
        /// Validates the user.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns>User authenticated</returns>
        public User ValidateUser(LoginDTO login)
        {
            try
            {
                return _loginRepository.ValidateUser(login);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }
    }
}
