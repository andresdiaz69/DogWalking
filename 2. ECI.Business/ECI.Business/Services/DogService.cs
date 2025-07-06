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

        /// <summary>
        /// Gets all dogs by client identifier.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>List of client's dogs</returns>
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

        /// <summary>
        /// Gets the dog.
        /// </summary>
        /// <param name="dogId">The dog identifier.</param>
        /// <returns>Dog found</returns>
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

        /// <summary>
        /// Saves the dog.
        /// </summary>
        /// <param name="dog">The dog.</param>
        /// <returns>True = dog saved ok</returns>
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
