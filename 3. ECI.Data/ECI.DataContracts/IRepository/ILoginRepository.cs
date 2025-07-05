namespace ECI.DataContracts.IRepository
{
    using ECI.Entities.DTO;
    using ECI.Entities.Entities;

    public interface ILoginRepository
    {
        Task<User> ValidateUser(LoginDTO login);
    }
}