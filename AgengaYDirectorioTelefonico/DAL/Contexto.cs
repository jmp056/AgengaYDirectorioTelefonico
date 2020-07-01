using AgengaYDirectorioTelefonico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgengaYDirectorioTelefonico.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Contactos>  Contactos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
