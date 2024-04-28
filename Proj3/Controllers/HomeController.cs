using Microsoft.AspNetCore.Mvc;
using Proj3.Models;
using System.Diagnostics;

namespace Proj3.Controllers
{
    /// <summary>
    /// Controller for handling home-related actions.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Attribute used in constructor
        /// </summary>
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Action method for rendering the index view.
        /// </summary>
        /// <returns>The index view result.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Action method for rendering the about view.
        /// </summary>
        /// <returns>The about view result.</returns>
        public async Task<IActionResult> About()
        {
            return View(await AboutModel.GetViewModelAsync());
        }

        /// <summary>
        /// Action method for rendering the undergraduate view.
        /// </summary>
        /// <returns>The undergraduate view result.</returns>
        public async Task<IActionResult> Undergraduate()
        {
            return View(await UndergraduateModel.GetViewModelAsync());
        }

        /// <summary>
        /// Action method for rendering the graduate view.
        /// </summary>
        /// <returns>The graduate view result.</returns>
        public async Task<IActionResult> Graduate()
        {
            return View(await GraduateModel.GetViewModelAsync());
        }

        /// <summary>
        /// Action method for rendering the coop view.
        /// </summary>
        /// <returns>The coop view result.</returns>
        public async Task<IActionResult> Coop()
        {
            var viewModel = await CoopModel.GetViewModelAsync();
            if (viewModel == null)
            {
                viewModel = new CoopViewModel { coopTable = new CoopTable() };
            }
            return View(viewModel);
        }

        /// <summary>
        /// Action method for rendering the employment view.
        /// </summary>
        /// <returns>The employment view result.</returns>
        public async Task<IActionResult> Employment()
        {
            var viewModel = await EmploymentModel.GetViewModelAsync();
            if (viewModel == null)
            {
                viewModel = new EmploymentViewModel { employmentTable = new EmploymentTable() };
            }
            return View(viewModel);
        }

        /// <summary>
        /// Action method for rendering the faculty view.
        /// </summary>
        /// <returns>The faculty view result.</returns>
        public async Task<IActionResult> Faculty()
        {
            return View(await FacultyModel.GetViewModelAsync());
        }

        /// <summary>
        /// Action method for rendering the error view.
        /// </summary>
        /// <returns>The error view result.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
