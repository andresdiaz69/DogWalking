namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.Entities;

    public interface IDogService
    {
        bool SaveDog(Dog dog);

        Dog GetDog(long dogId);

        List<Dog> GetAllDogsByClientId(long clientId);
    }
}
