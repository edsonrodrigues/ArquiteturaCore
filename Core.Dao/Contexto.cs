using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Entidade;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core.Dao
{
    public class Contexto :  IdentityDbContext
    {
        public DbSet<PessoaEntidade> Pessoas { get; set; }

        public DbSet<User> Users { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }


    }
}
