namespace ECI.BusinessServices.Services
{
    using ECI.BusinessContracts.IServices;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using System;
    using System.Collections.Generic;

    public class DogService : IDogService
    {
        private readonly IDogRepostory _dogRepository;

        public DogService(IDogRepostory dogRepository) 
        {
            _dogRepository = dogRepository;
        }

        public List<Dog> GetAllDogsByClientId(long clientId)
        {
            try
            {
                return _dogRepository.GetAllDogsByClientId(clientId);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        public Dog GetDog(long dogId)
        {
            try
            {
                return _dogRepository.GetDog(dogId);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        public bool SaveDog(Dog dog)
        {
            try
            {
                return _dogRepository.SaveDog(dog);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }
    }
}
