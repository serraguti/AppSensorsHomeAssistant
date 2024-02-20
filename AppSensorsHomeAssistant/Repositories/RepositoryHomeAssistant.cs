using AppSensorsHomeAssistant.Data;
using AppSensorsHomeAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace AppSensorsHomeAssistant.Repositories
{
    public class RepositoryHomeAssistant
    {
        private HomeAssistantContext context;

        public RepositoryHomeAssistant(HomeAssistantContext context)
        {
            this.context = context;
        }

        public async Task<List<SensorState>> GetSensorStatesAsync()
        {
            return await this.context.SensorStates.ToListAsync();
        }

        public async Task<List<SensorState>> 
            GetSensorStatesAsync(int idMetaData)
        {
            return await this.context.SensorStates
                .Where(x => x.IdMetaData == idMetaData)                
                .ToListAsync();
        }
    }
}
