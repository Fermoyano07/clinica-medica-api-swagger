using ClinicaMedica.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMedica.Data
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {
        }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de relación 1:N entre Paciente y Cita
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.Paciente)
                .WithMany(p => p.Citas)
                .HasForeignKey(c => c.IdPaciente);

            // Configuración de relación 1:N entre Medico y Cita
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.Medico)
                .WithMany(m => m.Citas)
                .HasForeignKey(c => c.IdMedico);

            // Configuración de relación 1:1 entre Cita y Tratamiento
            modelBuilder.Entity<Tratamiento>()
                .HasOne(t => t.Cita)
                .WithOne(c => c.Tratamiento)
                .HasForeignKey<Tratamiento>(t => t.IdCita);

            // Configuración de relación 1:1 entre Cita y Factura
            modelBuilder.Entity<Factura>()
                .HasOne(f => f.Cita)
                .WithOne(c => c.Factura)
                .HasForeignKey<Factura>(f => f.IdCita);
        }
    }
}
