using Microsoft.AspNetCore.Mvc;
using SemesterProjectUI.Models.EquationDirector;
using SemesterProjectUI.Models.Equations;
using SemesterProjectUI.Models.Responses;
using SemesterProjectUI.Services.ExpressionsServices;
using SemesterProjectUI.Services.OutputServices;

namespace SemesterProjectUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEquationService _equationService;
        private readonly IOutputService _outputService;

        public HomeController(ILogger<HomeController> logger, IEquationService equationService, IOutputService outputService)
        {
            _logger = logger;
            _equationService = equationService;
            _outputService = outputService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("StarterView");
        }
    }
}
