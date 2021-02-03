using FichaAtendimento.Shared.Model;
using Microsoft.EntityFrameworkCore;


namespace FichaAtendimento.Server.Data
{
    public class FichaContext : DbContext
    {

        public FichaContext (DbContextOptions<FichaContext> options) : base(options) { }


        public DbSet<Ficha> Fichas { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

    }
}
