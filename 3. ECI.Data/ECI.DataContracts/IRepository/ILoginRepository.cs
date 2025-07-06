namespace ECI.DataContracts.IRepository
{
    using ECI.Entities.DTO;
    using ECI.Entities.Entities;

    public interface ILoginRepository
    {
        /// <summary>
        /// Validates the user.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns>User authenticated</returns>
        User ValidateUser(LoginDTO login);
    }
}