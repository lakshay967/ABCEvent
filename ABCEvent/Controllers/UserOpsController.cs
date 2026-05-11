using Microsoft.AspNetCore.Mvc;
using DAL.IRepo;
using DAL.Repo;
using DAL.Models;
using ABCEvent.Models;
namespace ABCEvent.Controllers
{
    public class UserOpsController : Controller
    {
        public readonly IUserDetails _userDetails;
        public UserOpsController(IUserDetails userDetails)
        {
            _userDetails = userDetails;
        }

        public async Task<IActionResult> Index()
        {
            var res = await _userDetails.GetUserList();
            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            var res = new UserDetails
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailId = user.EmailId,
                Password = user.Password,
                isActive = user.isActive,
            };
            await _userDetails.AddUser(res);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var result = await _userDetails.GetUser(Id);
            var res = new User
            {
                Id = result.Id,
                FirstName = result.FirstName,
                LastName = result.LastName,
                EmailId = result.EmailId,
                Password = result.Password,
                isActive = result.isActive,
            };
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            var res = new UserDetails
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailId = user.EmailId,
                Password = user.Password,
                isActive = user.isActive,
            };
            await _userDetails.EditUser(res);
            return RedirectToAction("Index");
        }
    }
}
