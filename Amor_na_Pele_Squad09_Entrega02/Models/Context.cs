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
            public DbSet<CadastroContato> CadastroContatos { get; set; }

            public DbSet<CadastroEmpresa> CadastroEmpresas { get; set; }

            public DbSet<CadastroMulher> CadastroMulheres { get; set; }

            public DbSet<CadastroNewsletter> CadastroNewsletters { get; set; }

    }
}
