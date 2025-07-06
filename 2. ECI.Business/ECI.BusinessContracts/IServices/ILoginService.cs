namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.DTO;
    using ECI.Entities.Entities;

    public interface ILoginService
    {
        User ValidateUser(LoginDTO login);
    }
}