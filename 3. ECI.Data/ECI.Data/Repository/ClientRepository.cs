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
    
        public List<Client> GetAllCLients()
        {
            return _context.Clients
                //.Where(c => c.isActive)
                .AsNoTracking()
                .ToList();
        }

        public  Client GetClient(long clientId)
        {
            return  _context.Clients
                .Where(c => c.Id == clientId)
                .AsNoTracking()
                .FirstOrDefault();
        }

        public bool SaveClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateClient(Client client)
        {
            _context.Attach(client);
            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
