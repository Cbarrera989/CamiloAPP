using System.Threading.Tasks;

namespace CamiloAPP.Services
{
    public interface IAccountService
    {
        Task<bool> LoginAsync(string userName, string password);
    }
}