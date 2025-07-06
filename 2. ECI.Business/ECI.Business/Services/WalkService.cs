namespace ECI.BusinessServices.Services
{
    using ECI.BusinessContracts.IServices;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class WalkService : IWalkService
    {
        private readonly IWalkRepository _walkRepository;

        public WalkService(IWalkRepository walkRepository)
        {
            _walkRepository = walkRepository;
        }

        /// <summary>
        /// Deletes the walk.
        /// </summary>
        /// <param name="walkId">The walk identifier.</param>
        /// <returns>True = walk deleted ok</returns>
        public bool DeleteWalk(long walkId)
        {
            try
            {
                var walk = _walkRepository.GetWalkToUpdate(walkId);

                if (walk == null) return false;

                return _walkRepository.DeleteWalk(walk);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        /// <summary>
        /// Gets all walks.
        /// </summary>
        /// <returns></returns>
        public List<Walk> GetAllWalks()
        {
            try
            {
                return _walkRepository.GetAllWalks();
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        /// <summary>
        /// Gets the walk.
        /// </summary>
        /// <param name="walkId">The walk identifier.</param>
        /// <returns>Walk found</returns>
        public Walk GetWalk(long walkId)
        {
            try
            {
                return _walkRepository.GetWalk(walkId);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        /// <summary>
        /// Saves the walk.
        /// </summary>
        /// <param name="walk">The walk.</param>
        /// <returns>True = walk saved ok</returns>
        public bool SaveWalk(Walk walk)
        {
            try
            {
                return _walkRepository.SaveWalk(walk);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        /// <summary>
        /// Updates the walk.
        /// </summary>
        /// <param name="walk">The walk.</param>
        /// <returns>True = walk updated ok</returns>
        public bool UpdateWalk(Walk walk)
        {
            try
            {
                var walktoUpdate = _walkRepository.GetWalkToUpdate(walk.Id);
                if (walktoUpdate == null) return false;

                return _walkRepository.UpdateWalk(walk);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }
    }
}
