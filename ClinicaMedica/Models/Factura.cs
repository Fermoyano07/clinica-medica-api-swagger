using System.ComponentModel.DataAnnotations;

namespace ClinicaMedica.Models
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        // Clave foránea para la Cita
        public int IdCita { get; set; }
        public Cita Cita { get; set; }
    }
}
