namespace ECI.DataContracts.IRepository
{
    using ECI.Entities.DTO;
    using ECI.Entities.Entities;

    public interface ILoginRepository
    {
        User ValidateUser(LoginDTO login);
    }
}