namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IClientService
    {
        bool SaveClient(Client client);

        List<Client> GetAllCLients(bool onlyActiveClients);

        Client GetClient(long clientId);

        bool UpdateClient(Client client);
    }
}
