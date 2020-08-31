using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteWipro.Models;

    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext (DbContextOptions<ClienteDbContext> options)
            : base(options)
        {
        }

        public DbSet<TesteWipro.Models.Cliente> Cliente { get; set; }

        public DbSet<TesteWipro.Models.Locacao> Locacao { get; set; }

        public DbSet<TesteWipro.Models.Filme> Filme { get; set; }
    }
