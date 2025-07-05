namespace ECI.BusinessServices.Services
{
    using ECI.BusinessContracts.IServices;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.DTO;
    using ECI.Entities.Entities;
    using System;
    using System.Threading.Tasks;

    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            this._loginRepository = loginRepository;
        }

        public async Task<User> ValidateUser(LoginDTO login)
        {
            return await _loginRepository.ValidateUser(login);
        }
    }
}
