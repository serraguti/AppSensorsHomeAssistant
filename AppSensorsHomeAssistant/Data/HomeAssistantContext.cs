using AppSensorsHomeAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace AppSensorsHomeAssistant.Data
{
    public class HomeAssistantContext: DbContext
    {
        public HomeAssistantContext(DbContextOptions<HomeAssistantContext> options)
            :base(options) { }
        public DbSet<SensorState> SensorStates { get; set; }
    }
}
