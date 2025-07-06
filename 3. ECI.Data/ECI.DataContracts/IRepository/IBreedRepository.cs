namespace ECI.DataContracts.IRepository
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IBreedRepository
    {
        /// <summary>
        /// Gets all breeds.
        /// </summary>
        /// <returns>List of breeds</returns>
        List<Breed> GetAllBreeds();
    }
}
