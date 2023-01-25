using Core;
using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EBusiness.Areas.admin.Controllers
{
    [Area("admin")]
    public class OurSpecialTeamController : Controller
    {
        
        private readonly AppDbContext _context;
        public OurSpecialTeamController(AppDbContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            IEnumerable<OurSpecialTeam> ourSpecialTeams=_context.OurSpecialTeams.ToList();
            return View(ourSpecialTeams);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(OurSpecialTeam team)
        {
            if ( team.Photo== null)
            {
                ModelState.AddModelError("Photo", "olmaaz!");

            return View();
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int Id)
        {
            return View(); 
        }
        public IActionResult Delete(int Id)
        {
            return View();
        }
    }
}

