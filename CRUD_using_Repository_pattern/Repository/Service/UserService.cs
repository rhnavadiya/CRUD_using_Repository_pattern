using CRUD_using_Repository_pattern.Data;
using CRUD_using_Repository_pattern.Models;
using CRUD_using_Repository_pattern.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CRUD_using_Repository_pattern.Repository.Service
{
    public class UserService : IUser
    {
        private readonly ApplicationDbContext context;
        public UserService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var data = await context.Users.ToListAsync();
            return data;
        }

    

        public async Task<IEnumerable<User>> GetUsersById(int id)
        {
            var data = await context.Users.Where(x => x.userId == id).FirstOrDefaultAsync();
            return (IEnumerable<User>)data;
        }
    }
}
