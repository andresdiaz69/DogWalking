namespace ECI.DataContracts.IRepository
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IBreedRepository
    {
        List<Breed> GetAllBreeds();
    }
}
