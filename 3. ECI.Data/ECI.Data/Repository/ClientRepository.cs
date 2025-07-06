namespace ECI.DataRepository.Repository
{
    using ECI.DataContracts.IRepository;
    using ECI.DataRepository.Context;
    using ECI.Entities.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }



        /// <summary>
        /// Gets all c lients.
        /// </summary>
        /// <param name="onlyActiveClients">if set to <c>true</c> [only active clients].</param>
        /// <returns></returns>
        public List<Client> GetAllCLients(bool onlyActiveClients)
        {
            return _context.Clients
                .Where(c => (!onlyActiveClients || (onlyActiveClients && c.isActive)))
                .AsNoTracking()
                .ToList();
        }

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>Client found</returns>
        public Client GetClient(long clientId)
        {
            return  _context.Clients
                .Where(c => c.Id == clientId)
                .AsNoTracking()
                .FirstOrDefault();
        }

        /// <summary>
        /// Saves the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns>True = client saved ok</returns>
        public bool SaveClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            _context.Entry(client).State = EntityState.Detached;
            return true;
        }

        /// <summary>
        /// Updates the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns>True = client updated ok</returns>
        public bool UpdateClient(Client client)
        {
            _context.Attach(client);
            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
