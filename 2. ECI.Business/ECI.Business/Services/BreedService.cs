namespace ECI.BusinessServices.Services
{
    using ECI.BusinessContracts.IServices;
    using ECI.Entities.Entities;
    using System;
    using System.Collections.Generic;

    public class BreedService : IBreedService
    {
        private readonly IBreedService _breedService;

        public BreedService(IBreedService context)
        {
            _breedService = context;
        }

        public List<Breed> GetAllBreeds()
        {
            try
            {
                return _breedService.GetAllBreeds();
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }
    }
}
