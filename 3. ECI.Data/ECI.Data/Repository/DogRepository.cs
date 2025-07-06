namespace ECI.DataRepository.Repository
{
    using ECI.DataContracts.IRepository;
    using ECI.DataRepository.Context;
    using ECI.Entities.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class DogRepository : IDogRepostory
    {
        private readonly AppDbContext _context;

        public DogRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Dog> GetAllDogsByClientId(long clientId)
        {
            return _context.Dogs
               .Where(d => d.isActive && d.Client.Id == clientId)
               .AsNoTracking()
               .ToList();
        }

        public Dog GetDog(long dogId)
        {
            return _context.Dogs
                .Where(d => d.Id == dogId)
                .FirstOrDefault();
        }

        public bool SaveDog(Dog dog)
        {
            _context.Add(dog);
            _context.SaveChanges();
            return true;
        }
    }
}
