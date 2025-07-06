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

        /// <summary>
        /// Gets all dogs by client identifier.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>List of client's dogs</returns>
        public List<Dog> GetAllDogsByClientId(long clientId)
        {
            return _context.Dogs
               .Where(d => d.isActive && d.Client.Id == clientId)
               .AsNoTracking()
               .ToList();
        }

        /// <summary>
        /// Gets the dog.
        /// </summary>
        /// <param name="dogId">The dog identifier.</param>
        /// <returns>Dog found</returns>
        public Dog GetDog(long dogId)
        {
            return _context.Dogs
                .Where(d => d.Id == dogId)
                .FirstOrDefault();
        }

        /// <summary>
        /// Saves the dog.
        /// </summary>
        /// <param name="dog">The dog.</param>
        /// <returns>True = dog saved ok</returns>
        public bool SaveDog(Dog dog)
        {
            _context.Add(dog);
            _context.SaveChanges();
            return true;
        }
    }
}
