namespace ECI.BusinessContracts.IServices
{
    using ECI.Entities.Entities;
    using System.Collections.Generic;

    public interface IClientService
    {
        /// <summary>
        /// Saves the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns>True = client saved ok</returns>
        bool SaveClient(Client client);

        /// <summary>
        /// Gets all c lients.
        /// </summary>
        /// <param name="onlyActiveClients">if set to <c>true</c> [only active clients].</param>
        /// <returns></returns>
        List<Client> GetAllCLients(bool onlyActiveClients);

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>Client found</returns>
        Client GetClient(long clientId);

        /// <summary>
        /// Updates the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns>True = client updated ok</returns>
        bool UpdateClient(Client client);
    }
}
