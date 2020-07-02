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
    public partial class rEventos : Form
    {
        public int EventoId;

        public rEventos(int eventoId)
        {
            this.EventoId = eventoId;
            InitializeComponent();
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            EventoId = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            HoraComboBox.SelectedIndex = -1;
            DescripcionTextBox.Text = string.Empty;
            NotaTextBox.Text = string.Empty;
        }

        private Eventos LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Eventos Evento = new Eventos();

            Evento.EventoId = EventoId;
            Evento.Fecha = FechaDateTimePicker.Value;
            Evento.Hora = HoraComboBox.SelectedIndex;
            Evento.Descripcion = DescripcionTextBox.Text;
            Evento.Nota = NotaTextBox.Text;

            return Evento;
        }

        private void LlenaCampo(Eventos Evento)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {

            FechaDateTimePicker.Value = Evento.Fecha;
            HoraComboBox.SelectedIndex = Evento.Hora;
            DescripcionTextBox.Text = Evento.Descripcion;
            NotaTextBox.Text = Evento.Nota;

        }

        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario exist en una base de datos!
        {
            Eventos Evento = new Eventos();

            RepositorioBase<Eventos> Repositorio = new RepositorioBase<Eventos>();
            Evento = Repositorio.Buscar(EventoId);

            return (Evento != null);
        }

        private void Buscar()
        {
            RepositorioBase<Eventos> Repositorio = new RepositorioBase<Eventos>();
            Eventos Evento = new Eventos();

            Evento = Repositorio.Buscar(EventoId);

            if (Evento != null)
            {
                LlenaCampo(Evento);
            }
            else
            {
                Limpiar();
                MessageBox.Show("No fue posible culminar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Guardar()
        {
            RepositorioBase<Eventos> Repositorio = new RepositorioBase<Eventos>();

            Eventos Evento = new Eventos();

            bool Paso = false;

            Evento = LlenaClase();

            if (EventoId == 0)
            {
                Paso = Repositorio.Guardar(Evento);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No fue posible modificar este Evento, inténtelo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("¿Seguro que desea modificar este Evento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Paso = Repositorio.Modificar(Evento);
                    if (Paso)
                    {
                        MessageBox.Show("El Evento se guardó correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible guardar este Evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El Evento se guardó correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No fue posible guardar este Evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FechaDateTimePicker.Focus();
            }

            FechaDateTimePicker.Focus();
        }

        private void Eliminar()
        {
            RepositorioBase<Eventos> Repositorio = new RepositorioBase<Eventos>();

            bool Paso = false;

            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se pudo eliminar este Evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FechaDateTimePicker.Focus();
                return;
            }
            else
            {
                Eventos Evento = Repositorio.Buscar(EventoId);
                if (Evento != null)
                {
                    var result = MessageBox.Show("¿Seguro que desea eliminar este Evento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Paso = Repositorio.Eliminar(EventoId);
                        if (Paso)
                        {
                            MessageBox.Show("El Evento fue eliminado correctamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar este Evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            FechaDateTimePicker.Focus();
                        }
                        return;
                    }
                }

            }
            FechaDateTimePicker.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void rEventos_Load(object sender, EventArgs e)
        {
            if (EventoId > 0)
            {
                Buscar();
            }
        }
    }
}
