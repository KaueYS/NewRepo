using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebListaEsperaMentoria.Models;

namespace WebListaEsperaMentoria.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PacienteModel> PACIENTES { get; set; }
        public DbSet<UsuarioModel> USUARIOS { get; set; }
    }
}
