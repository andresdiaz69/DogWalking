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

        /// <summary>
        /// Deletes the walk.
        /// </summary>
        /// <param name="walkId">The walk identifier.</param>
        /// <returns>True = walk deleted ok</returns>
        public bool DeleteWalk(Walk walk)
        {
            _context.Attach(walk);
            _context.Entry(walk).State = EntityState.Deleted;
            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Gets all walks.
        /// </summary>
        /// <returns></returns>
        public List<Walk> GetAllWalks()
        {
            return _context.Walks
                .AsNoTracking()
                .Include(d => d.Dog)
                .ThenInclude(d => d.Client)
                .ToList();
        }

        /// <summary>
        /// Gets the walk.
        /// </summary>
        /// <param name="walkId">The walk identifier.</param>
        /// <returns>Walk found</returns>
        public Walk GetWalk(long walkId)
        {
            return _context.Walks
                .AsNoTracking()
                .Include(w => w.Dog)
                .ThenInclude(d => d.Client)
                .FirstOrDefault(w => w.Id == walkId);
        }

        /// <summary>
        /// Gets the walk.
        /// </summary>
        /// <param name="walkId">The walk identifier.</param>
        /// <returns>Walk found</returns>
        public Walk GetWalkToUpdate(long walkId)
        {
            return _context.Walks
                .AsNoTracking()
                .FirstOrDefault(w => w.Id == walkId);
        }

        /// <summary>
        /// Saves the walk.
        /// </summary>
        /// <param name="walk">The walk.</param>
        /// <returns>True = walk saved ok</returns>
        public bool SaveWalk(Walk walk)
        {
            _context.Walks.Add(walk);
            _context.SaveChanges();
            _context.Entry(walk).State = EntityState.Detached;
            return true;
        }

        /// <summary>
        /// Updates the walk.
        /// </summary>
        /// <param name="walk">The walk.</param>
        /// <returns>True = walk updated ok</returns>
        public bool UpdateWalk(Walk walk)
        {
            _context.Attach(walk);
            _context.Entry(walk).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
