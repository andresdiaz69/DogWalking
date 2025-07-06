namespace ECI.DataRepository.Repository
{
    using ECI.DataContracts.IRepository;
    using ECI.DataRepository.Context;
    using ECI.Entities.Entities;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class WalkRepository : IWalkRepository
    {
        private readonly AppDbContext _context;

        public WalkRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool DeleteWalk(Walk walk)
        {
            _context.Walks.Remove(walk);
            _context.SaveChanges();
            return true;
        }

        public List<Walk> GetAllWalks()
        {
            return _context.Walks
                .AsNoTracking()
                .ToList();
        }

        public Walk GetWalk(long walkId)
        {
            return _context.Walks
                .Where(w => w.Id == walkId)
                .FirstOrDefault();
        }

        public bool SaveWalk(Walk walk)
        {
            _context.Walks.Add(walk);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateWalk(Walk walk)
        {
            _context.Walks.Update(walk);
            _context.SaveChanges();
            return true;
        }
    }
}
