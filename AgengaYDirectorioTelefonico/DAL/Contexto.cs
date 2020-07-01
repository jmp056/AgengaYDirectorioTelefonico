using AgengaYDirectorioTelefonico.Entidades;
using System.Data.Entity;

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
