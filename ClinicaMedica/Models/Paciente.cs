using System.ComponentModel.DataAnnotations;

namespace ClinicaMedica.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        // Relación con Citas (1:N)
        public ICollection<Cita> Citas { get; set; }
    }
}
