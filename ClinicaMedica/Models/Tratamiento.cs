using System.ComponentModel.DataAnnotations;

namespace ClinicaMedica.Models
{
    public class Tratamiento
    {
        [Key]
        public int IdTratamiento { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }  // En minutos
        public decimal Costo { get; set; }

        // Clave foránea para la Cita
        public int IdCita { get; set; }
        public Cita Cita { get; set; }
    }
}
