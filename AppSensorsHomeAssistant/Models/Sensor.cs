using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppSensorsHomeAssistant.Models
{
    [Table("states_meta")]
    public class Sensor
    {
        [Key]
        [Column("metadata_id")]
        public int IdSensor { get; set; }
        [Column("entity_id")]
        public string Entidad { get; set; }
    }
}
