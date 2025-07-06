namespace ECI.DataContracts.IRepository
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IDogRepostory
    {
        /// <summary>
        /// Saves the dog.
        /// </summary>
        /// <param name="dog">The dog.</param>
        /// <returns>True = dog saved ok</returns>
        bool SaveDog(Dog dog);

        /// <summary>
        /// Gets the dog.
        /// </summary>
        /// <param name="dogId">The dog identifier.</param>
        /// <returns>Dog found</returns>
        Dog GetDog(long dogId);

        /// <summary>
        /// Gets all dogs by client identifier.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>List of client's dogs</returns>
        List<Dog> GetAllDogsByClientId(long clientId);
    }
}
