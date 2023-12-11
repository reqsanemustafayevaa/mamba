using examtask.business.Services.Interfaces;
using examtask.core.Repostories.Interfaces;
using examtask.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace examtask.MVC.Areas.manage.Controllers
{
    [Area("manage")]
    public class TeamController : Controller
    {
        private readonly ITeamService _teamservice;
        public TeamController(ITeamService teamService)
        {
            _teamservice=teamService;
        }
        public async Task< IActionResult> Index()
        {
            var teams = await _teamservice.GetAllAsync();
            return View(teams);



           
            
        }
        public async Task<IActionResult> CreateAssync()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Team team)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _teamservice.CreateAsync(team);
            return RedirectToAction("Index");
        }


    }
}
