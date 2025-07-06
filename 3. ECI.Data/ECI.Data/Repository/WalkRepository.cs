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
            _context.Attach(walk);
            _context.Entry(walk).State = EntityState.Deleted;
            _context.SaveChanges();
            return true;
        }

        public List<Walk> GetAllWalks()
        {
            return _context.Walks
                .AsNoTracking()
                .Include(d => d.Dog)
                .ThenInclude(d => d.Client)
                .ToList();
        }

        public Walk GetWalk(long walkId)
        {
            return _context.Walks
                .AsNoTracking()
                .Include(w => w.Dog)
                .ThenInclude(d => d.Client)
                .FirstOrDefault(w => w.Id == walkId);
        }

        public bool SaveWalk(Walk walk)
        {
            _context.Walks.Add(walk);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateWalk(Walk walk)
        {
            _context.Attach(walk);
            _context.Entry(walk).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
