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
        public int Hora{ get; set; }
        public string Nota { get; set; }

        public Eventos()
        {
            EventoId = 0;
            Descripcion = string.Empty;
            Fecha = DateTime.Now;
            Hora = 0;
            Nota = string.Empty;
        }
    }
}
