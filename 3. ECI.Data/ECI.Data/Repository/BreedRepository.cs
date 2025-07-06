namespace ECI.DataRepository.Repository
{
    using ECI.DataContracts.IRepository;
    using ECI.DataRepository.Context;
    using ECI.Entities.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class BreedRepository : IBreedRepository
    {
        private readonly AppDbContext _context;

        public BreedRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Breed> GetAllBreeds()
        {
            return _context.Breeds
                .Where(b => b.isActive)
                .AsNoTracking()
                .ToList();
        }
    }
}
