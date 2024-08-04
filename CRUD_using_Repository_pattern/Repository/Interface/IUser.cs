using CRUD_using_Repository_pattern.Models;

namespace CRUD_using_Repository_pattern.Repository.Interface
{
    public interface IUser
    {
       
        Task<IEnumerable<User>> GetUsers();

        Task<IEnumerable<User>> GetUsersById(int id);

    }
}
