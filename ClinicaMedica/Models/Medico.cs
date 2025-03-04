using System.ComponentModel.DataAnnotations;

namespace ClinicaMedica.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        // Relación con Citas (1:N)
        public ICollection<Cita> Citas { get; set; }
    }
}
