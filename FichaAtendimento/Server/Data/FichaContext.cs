using FichaAtendimento.Server.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAtendimento.Server.Data
{
    public class FichaContext : DbContext
    {

        public FichaContext (DbContextOptions<FichaContext> options) : base(options) { }


        public DbSet<Ficha> Fichas { get; set; }


    }
}
