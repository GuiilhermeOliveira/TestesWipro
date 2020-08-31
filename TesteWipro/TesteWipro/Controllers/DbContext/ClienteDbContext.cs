using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWipro.Controllers.DbContext
{
    public class ClienteDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public ClienteDbContext(DbContextOptions<ClienteDbContext> options)

       : base(options)
        {

        }

        public DbSet<TesteWipro.Models.Cliente> Cliente { get; set; }

        public DbSet<TesteWipro.Models.Filme> Filme { get; set; }

        public DbSet<TesteWipro.Models.Locacao> Locacao { get; set; }
    }
}
