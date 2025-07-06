namespace ECI.BusinessServices.Services
{
    using ECI.BusinessContracts.IServices;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using System;
    using System.Collections.Generic;

    public class BreedService : IBreedService
    {
        private readonly IBreedRepository _breedRepository;

        public BreedService(IBreedRepository context)
        {
            _breedRepository = context;
        }

        public List<Breed> GetAllBreeds()
        {
            try
            {
                return _breedRepository.GetAllBreeds();
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }
    }
}
