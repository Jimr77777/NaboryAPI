using System.Threading.Tasks;

namespace NaboryAPI
{
    public interface IUserRepository
    {
        public Task<User> GetByIdAsync(int id);
    }
}
