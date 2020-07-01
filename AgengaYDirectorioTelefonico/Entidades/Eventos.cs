using System;
using System.ComponentModel.DataAnnotations;

namespace AgengaYDirectorioTelefonico.Entidades
{
    public class Eventos
    {
        [Key]
        public int EventoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Nota { get; set; }

        public Eventos()
        {
            EventoId = 0;
            Descripcion = string.Empty;
            Fecha = DateTime.Now;
            Nota = string.Empty;
        }
    }
}
