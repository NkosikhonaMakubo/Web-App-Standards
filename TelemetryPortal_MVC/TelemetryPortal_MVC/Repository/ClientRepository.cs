using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(TechtrendsContext context) : base(context) 
        {
        }
        public IEnumerable<Client> GetPopularClients(int count)
        {
            return _context.Clients.OrderByDescending(c => c.Followers).Take(count).ToList();
        }
    }
}
