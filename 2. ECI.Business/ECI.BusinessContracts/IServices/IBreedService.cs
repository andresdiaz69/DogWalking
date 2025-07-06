namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IBreedService
    {
        /// <summary>
        /// Gets all breeds.
        /// </summary>
        /// <returns>List of breeds</returns>
        List<Breed> GetAllBreeds();
    }
}
