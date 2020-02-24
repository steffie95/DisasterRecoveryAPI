using System.Threading.Tasks;
using DisasterRecoveryAPI.Models;

namespace DisasterRecoveryAPI
    {
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string user, string password);

        Task<bool> UserExists(string username);

    }
}