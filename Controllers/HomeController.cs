using Microsoft.AspNetCore.Mvc;
using Proj3.Models;
using System.Diagnostics;

namespace Proj3.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> News()
        {
            return View(await NewsModel.GetViewModelAsync());
        }

        public async Task<IActionResult> About() 
        {
            return View(await AboutModel.GetViewModelAsync());
        }

        public async Task<IActionResult> Undergraduate()
        {
            return View(await UndergraduateModel.GetViewModelAsync());

        }
        public async Task<IActionResult> Graduate()
        {
            return View(await GraduateModel.GetViewModelAsync());

        }
        public async Task<IActionResult> Coop()
        {
            var viewModel = await CoopModel.GetViewModelAsync();
            if (viewModel == null)
            {
                viewModel = new CoopViewModel { coopTable = new CoopTable() };
            }
            return View(viewModel);
        }
        public async Task<IActionResult> Employment()
        {
            var viewModel = await EmploymentModel.GetViewModelAsync();
            if (viewModel == null)
            {
                viewModel = new EmploymentViewModel { employmentTable = new EmploymentTable() };
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Faculty()
        {
            return View(await FacultyModel.GetViewModelAsync());

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
