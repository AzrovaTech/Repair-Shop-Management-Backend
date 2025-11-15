using AM.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.IRepository
{
    public interface IUserRepository
    {
        public Task<User> GetUserById(string userId);
    }
}
