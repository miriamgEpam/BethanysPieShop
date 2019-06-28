using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

namespace BethanysPieShop.Controllers
{
    public class ExoticBeberageController : Controller
    {
        private readonly IExoticBeberageRepository _exoticBeberageRepository;

        public ExoticBeberageController(IExoticBeberageRepository exoticBeberageRepository)
        {
            _exoticBeberageRepository = exoticBeberageRepository; 
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult saveExoticBeberage(ExoticBeberage exoticBeberage ) {

            if (ModelState.IsValid)
            {
                _exoticBeberageRepository.AddExoticBeberage(exoticBeberage); 

            }

            return RedirectToAction("ExoticBeberageComplete"); 
        }

        public IActionResult ExoticBeberageComplete()
        {
            return View();
        }

        [HttpGet]
        public IActionResult getAllExoticBeberages()
        {
            var ExoticBeberageslist = _exoticBeberageRepository.GetAllExoticBeberages().OrderBy(e => e.Description);

            var exoticBeberageVM = new ExoticBeberageVM()
            {
                ExoticBeberages = ExoticBeberageslist.ToList(),
                Title = "All exotic beberages"
            };
            return View(exoticBeberageVM); 
                
        }
        public IActionResult DetailsExoticBeberage (int id)
        {
            var eb = _exoticBeberageRepository.GetExoticBeberage(id);
            if (eb == null)
                return NotFound();

            return View (eb); 
        }


    }
}