using System.ComponentModel.DataAnnotations;

namespace AgengaYDirectorioTelefonico.Entidades
{
    public class Contactos
    {
        [Key]
        public int ContactoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Nota { get; set; }

        public Contactos()
        {
            ContactoId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Correo = string.Empty;
            Direccion = string.Empty;
            Nota = string.Empty;
        }
    }
}
