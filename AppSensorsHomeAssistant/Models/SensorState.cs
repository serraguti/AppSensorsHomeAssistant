using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppSensorsHomeAssistant.Models
{
    [Table("v_states_sensors")]
    public class SensorState
    {
        [Key]
        [Column("state_id")]
        public int IdState { get; set; }
        [Column("metadata_id")]
        public int IdMetaData { get; set; }
        [Column("entity_id")]
        public string Entidad { get; set; } = null!;
        [Column("state")]
        public string Estado { get; set; } = null!;
        [Column("shared_attrs")]
        public string Atributos { get; set; } = null!;

    }
}
