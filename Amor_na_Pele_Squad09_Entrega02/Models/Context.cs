using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Amor_na_Pele_Squad09_Entrega02.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
            public DbSet<CadastroContato> CadastroContato { get; set; }

            public DbSet<CadastroEmpresa> CadastroEmpresa { get; set; }

            public DbSet<CadastroMulher> CadastroMulher { get; set; }

            public DbSet<CadastroNewsletter> CadastroNewsletter { get; set; }

    }
}
