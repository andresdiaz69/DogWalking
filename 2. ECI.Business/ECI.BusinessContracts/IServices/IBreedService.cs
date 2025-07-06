namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IBreedService
    {
        List<Breed> GetAllBreeds();
    }
}
