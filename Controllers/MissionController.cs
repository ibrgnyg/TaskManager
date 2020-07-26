using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManager.Models;
using TaskManager.Service;

namespace TaskManager.Controllers
{
    public class MissionController : Controller
    {
        private readonly MissionService _missionService;
        private UserManager<AppUser> _userManager;
        private IHostingEnvironment _environment;
        public MissionController(MissionService missionService,UserManager<AppUser> userManager,IHostingEnvironment hostingEnvironment)
        {
            _missionService = missionService;
            _userManager = userManager;
            _environment = hostingEnvironment;
        }

        public IActionResult Index(int order)
        {

            ViewBag.Order = new List<SelectListItem>()
            {
                new SelectListItem{Value="0" ,Text="Sırala",Selected= true},
                new SelectListItem{Value="1" ,Text="A"},
                new SelectListItem{Value="2" ,Text="Z"},
            };
            var filterlist = _missionService.GetList().OrderByDescending(x=>Guid.NewGuid());
            if(order==1)
            {
                filterlist = filterlist.OrderBy(x => x.TaskName);
                
            }
            if(order==2)
            {
                filterlist = filterlist.OrderByDescending(x => x.TaskName);
            }
           
            return View(filterlist);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Mission mission, IFormFile file)
        {

            if (file != null)
            {

                var path = Path.Combine(_environment.WebRootPath, "Photo", file.FileName);
                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                mission.Photo = file.FileName;
            }

            mission.CreateDate = DateTime.Now;
            mission.User = await _userManager.GetUserAsync(User);
            mission.CreateBy = await _userManager.GetUserNameAsync(mission.User);

            _missionService.Save(mission);
            
           
            return RedirectToAction("Index", "mission");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
           
            return View(_missionService.Finds(id));
        }
        [Authorize]
        public async Task<IActionResult> MyMission()
        {
            var user = await _userManager.GetUserAsync(User);
            var list = _missionService.GetList().Where(x => x.UserId == user.Id);
            return View(list);
        }

        public async Task<IActionResult> Edit(Mission mission, IFormFile file)
        {
            if (file != null)
            {

                var path = Path.Combine(_environment.WebRootPath, "Photo", file.FileName);
                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                mission.Photo = file.FileName;
            }
            mission.UpdateDate = DateTime.Now;
            mission.User = await _userManager.GetUserAsync(User);
            mission.UpdatedBy = await _userManager.GetUserNameAsync(mission.User);
            _missionService.Update(mission);
            return RedirectToAction("Index", "mission");
        }

        public IActionResult Detail(int id)
        {
            return View(_missionService.Finds(id));
        }


        public IActionResult Delete(int id)
        {
            _missionService.Delete(_missionService.Finds(id));
            return RedirectToAction("Index", "mission");
        }

    }
}