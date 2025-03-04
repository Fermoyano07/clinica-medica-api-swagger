using System.ComponentModel.DataAnnotations;

namespace ClinicaMedica.Models
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }

        // Claves foráneas
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; }

        public int IdMedico { get; set; }
        public Medico Medico { get; set; }

        // Relación con Tratamiento (1:1)
        public Tratamiento Tratamiento { get; set; }

        // Relación con Factura (1:1)
        public Factura Factura { get; set; }
    }
}
