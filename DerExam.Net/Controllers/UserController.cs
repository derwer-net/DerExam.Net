using DerExam.Net.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DerExam.Net.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<UserExt> userManager;

        public UserController(UserManager<UserExt> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            return View(users);
        }
    }
}