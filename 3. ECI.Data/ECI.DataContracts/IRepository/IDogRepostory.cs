namespace ECI.DataContracts.IRepository
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IDogRepostory
    {
        bool SaveDog(Dog dog);

        Dog GetDog(long dogId);

        List<Dog> GetAllDogsByClientId(long clientId);
    }
}
