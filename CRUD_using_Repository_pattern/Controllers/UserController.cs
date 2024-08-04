using CRUD_using_Repository_pattern.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_using_Repository_pattern.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser users;

        public UserController(IUser users)
        {
            this.users = users;
        }

        public async Task<IActionResult> Getusers()
        {
            var data = await users.GetUsers();
            return View(data);
        }

        public async Task<IActionResult> getuserById(int id)
        {
            var data = await users.GetUsersById(id);
            return View(data);
        }
    }
}
