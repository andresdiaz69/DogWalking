namespace ECI.DataRepository.IRepository
{
    using ECI.DataContracts.IRepository;
    using ECI.DataRepository.Context;
    using ECI.Entities.DTO;
    using ECI.Entities.Entities;
    using Microsoft.EntityFrameworkCore;

    public class LoginRepository : ILoginRepository
    {
        private readonly AppDbContext _context;

        public LoginRepository(AppDbContext context)
        {
            _context = context;
        }

        public User ValidateUser(LoginDTO login)
        {
            var userValid = _context.Users.Where(
                u => u.Email == login.Email && u.Password == login.Password)
                .AsNoTracking()
                .FirstOrDefault();

            return userValid;
        }
    }
}
