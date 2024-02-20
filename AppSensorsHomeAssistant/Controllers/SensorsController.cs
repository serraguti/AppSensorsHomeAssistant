using AppSensorsHomeAssistant.Models;
using AppSensorsHomeAssistant.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AppSensorsHomeAssistant.Controllers
{
    public class SensorsController : Controller
    {
        private RepositoryHomeAssistant repo;

        public SensorsController(RepositoryHomeAssistant repo)
        {
            this.repo = repo;
        }
    
        public async Task<IActionResult> Index()
        {
            List<SensorState> sensores = await this.repo.GetSensorStatesAsync(316);
            return View(sensores);
        }

        public async Task<IActionResult> SearchSensorState(int id)
        {
            List<SensorState> sensores = await this.repo.GetSensorStatesAsync(id);
            return View(sensores);
        }
    }
}
