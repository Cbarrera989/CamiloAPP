using CamiloAPP.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CamiloAPP.Services
{
    public interface IClientService
    {
        Task<List<Client>> GetClients();
    }

}
