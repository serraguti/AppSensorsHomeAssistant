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

        public async Task<IActionResult> MisSensores()
        {
            List<Sensor> sensores = await this.repo.GetSensorsAsync();
            return View(sensores);
        }

        public async Task<IActionResult> Index()
        {
            List<SensorState> sensoresStates = await this.repo.GetSensorStatesAsync();
            return View(sensoresStates);
        }

        public async Task<IActionResult> SearchSensorState(int id)
        {
            List<SensorState> sensoresStates = await this.repo.GetSensorStatesAsync(id);
            return View(sensoresStates);
        }
    }
}
