using AM.Data.Context;
using AM.Domain.Entities.User;
using AM.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AMContext _context;

        public UserRepository(AMContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserById(string userId)
        {
            User result = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
            return result;
        }
    }
}
