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
           return View();
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

        //public string Staff()
        //{
        //    return staffRepository.Get(3)?.FirstName;
        //}
     
    }
}
