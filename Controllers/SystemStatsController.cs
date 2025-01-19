using Microsoft.AspNetCore.Mvc;
using SystemMonitor.Services;
using System.Threading.Tasks;

namespace SystemMonitor.Controllers
{
    public class SystemStatsController : Controller
    {
        private readonly ISystemStatsService _systemStatsService;

        public SystemStatsController(ISystemStatsService systemStatsService)
        {
            _systemStatsService = systemStatsService;
        }

        public IActionResult Index()
        {
            return View("~/Views/SystemStats/Index.cshtml");
        }

        [HttpGet]
        public async Task<IActionResult> GetStats()
        {
            var stats = await _systemStatsService.GetSystemStatsAsync();
            return Json(stats);
        }
    }
} 