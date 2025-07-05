namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.DTO;
    using ECI.Entities.Entities;

    public interface ILoginService
    {
        Task<User> ValidateUser(LoginDTO login);
    }
}