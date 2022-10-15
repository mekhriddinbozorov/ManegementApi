using ManegementApi.Models;
using ManegementApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ManegementApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStaffRepository staffRepository;

        public HomeController(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }
        public ViewResult Index()
        {
            HomeIndexViewModel homeIndexView = new HomeIndexViewModel()
            {
                Staffs = staffRepository.GetAll()
            };
           return View(homeIndexView);
        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsView = new HomeDetailsViewModel()
            {
                Staff = staffRepository.Get(id ?? 1),
                Title = "Staff Details"
            };
            return View(homeDetailsView);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Staff staff)
        {
            if (ModelState.IsValid)
            {
                var newStaff = staffRepository.Create(staff);
                return RedirectToAction("details", new { id = newStaff.Id });
            }

            return View();
        }

        //public string Staff()
        //{
        //    return staffRepository.Get(3)?.FirstName;
        //}
     
    }
}
