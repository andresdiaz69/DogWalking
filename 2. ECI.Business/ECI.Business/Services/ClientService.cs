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

        public bool UpdateClient(Client client)
        {
            try
            {
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
