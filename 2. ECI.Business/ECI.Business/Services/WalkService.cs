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

        public bool DeleteWalk(long walkId)
        {
            try
            {
                var walk = GetWalk(walkId);
                return _walkRepository.DeleteWalk(walk);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

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

        public bool UpdateWalk(Walk walk)
        {
            try
            {
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
