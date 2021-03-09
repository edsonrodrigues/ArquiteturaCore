using Core.Entities.Entidade;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dao.Context
{
    public class Context : DbContext  // IdentityDbContext
    {
        public DbSet<PessoaEntidade> Pessoas { get; set; }
        public Context(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }


    }
}
