namespace ECI.BusinessServices.Services
{
    using ECI.BusinessContracts.IServices;
    using ECI.DataContracts.IRepository;
    using ECI.Entities.Entities;
    using System;
    using System.Collections.Generic;

    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository) 
        { 
            _clientRepository = clientRepository;
        }

        /// <summary>
        /// Gets all c lients.
        /// </summary>
        /// <param name="onlyActiveClients">if set to <c>true</c> [only active clients].</param>
        /// <returns></returns>
        public List<Client> GetAllCLients(bool onlyActiveClients)
        {
            try
            {
                return _clientRepository.GetAllCLients(onlyActiveClients);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>Client found</returns>
        public Client GetClient(long clientId)
        {
            try
            {
                return _clientRepository.GetClient(clientId);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        /// <summary>
        /// Saves the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns>True = client saved ok</returns>
        public bool SaveClient(Client client)
        {
            try
            {
                return _clientRepository.SaveClient(client);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }

        /// <summary>
        /// Updates the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns>True = client updated ok</returns>
        public bool UpdateClient(Client client)
        {
            try
            {
                var clientUpdate = GetClient(client.Id);
                if (clientUpdate == null) return false;

                return _clientRepository.UpdateClient(client);
            }
            catch (Exception ex)
            {
                // Log ex
                throw;
            }
        }
    }
}
