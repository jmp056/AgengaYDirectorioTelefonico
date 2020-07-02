using AgengaYDirectorioTelefonico.BLL;
using AgengaYDirectorioTelefonico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgengaYDirectorioTelefonico.UI.Registros
{
    public partial class rContactos : Form
    {
        public int ContactoId;

        public rContactos(int contactoId)
        {
            this.ContactoId = contactoId;
            InitializeComponent();
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            NombreTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            CorreoTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            NotaTextBox.Text = string.Empty;
        }

        private Contactos LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Contactos Contacto = new Contactos();

            Contacto.ContactoId = ContactoId;
            Contacto.Nombre = NombreTextBox.Text;
            Contacto.Telefono = TelefonoMaskedTextBox.Text;
            Contacto.Celular = CelularMaskedTextBox.Text;
            Contacto.Correo = CorreoTextBox.Text;
            Contacto.Direccion = DireccionTextBox.Text;
            Contacto.Nota = NotaTextBox.Text;

            return Contacto;
        }

        private void LlenaCampo(Contactos Contacto)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {

            NombreTextBox.Text = Contacto.Nombre;
            TelefonoMaskedTextBox.Text = Contacto.Telefono;
            CelularMaskedTextBox.Text = Contacto.Celular;
            CorreoTextBox.Text = Contacto.Correo;
            DireccionTextBox.Text = Contacto.Direccion;
            NotaTextBox.Text = Contacto.Nota;

        }

        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario exist en una base de datos!
        {
            Contactos Contacto = new Contactos();

            RepositorioBase<Contactos> Repositorio = new RepositorioBase<Contactos>();
            Contacto = Repositorio.Buscar(ContactoId);

            return (Contacto != null);
        }

        private void Buscar()
        {
            RepositorioBase<Contactos> Repositorio = new RepositorioBase<Contactos>();
            Contactos Contacto = new Contactos();

            Contacto = Repositorio.Buscar(ContactoId);

            if (Contacto != null)
            {
                LlenaCampo(Contacto);
            }
            else
            {
                Limpiar();
                MessageBox.Show("No fue posible culminar esta tarea","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Guardar()
        {
            RepositorioBase<Contactos> Repositorio = new RepositorioBase<Contactos>();

            Contactos Contacto = new Contactos();

            bool Paso = false;

            Contacto = LlenaClase();

            if (ContactoId == 0)
            {
                Paso = Repositorio.Guardar(Contacto);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No fue posible modificar este contacto, inténtelo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("¿Seguro que desea modificar este contacto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Paso = Repositorio.Modificar(Contacto);
                    if (Paso)
                    {
                        MessageBox.Show("El contacto se guardó correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible guardar este contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    return;
                }
            }

            if (Paso)
            {
                MessageBox.Show("El contacto se guardó correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No fue posible guardar este contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreTextBox.Focus();
            }

            NombreTextBox.Focus();
        }

        private void Eliminar()
        {
            RepositorioBase<Contactos> Repositorio = new RepositorioBase<Contactos>();

            bool Paso = false;

            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se pudo eliminar este contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreTextBox.Focus();
                return;
            }
            else
            {
                Contactos Contacto = Repositorio.Buscar(ContactoId);
                if (Contacto != null)
                {
                    var result = MessageBox.Show("¿Seguro que desea eliminar este contacto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Paso = Repositorio.Eliminar(ContactoId);
                        if (Paso)
                        {
                            MessageBox.Show("El contacto fue eliminado correctamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar este contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NombreTextBox.Focus();
                        }
                        return;
                    }
                }

            }
            NombreTextBox.Focus();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void rContactos_Load(object sender, EventArgs e)
        {
            if (ContactoId > 0)
            {
                Buscar();
            }
        }
    }
}
