using AgengaYDirectorioTelefonico.BLL;
using AgengaYDirectorioTelefonico.Entidades;
using AgengaYDirectorioTelefonico.UI.Registros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AgengaYDirectorioTelefonico.UI.Consultas
{
    public partial class cContactos : Form
    {

        private List<Contactos> ListadoContactos = new List<Contactos>();

        public cContactos()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            RepositorioBase<Contactos> Repositorio = new RepositorioBase<Contactos>();
            ListadoContactos = new List<Contactos>();
            ListadoContactos = Repositorio.GetList(p => true);

            switch (FiltroComboBox.SelectedIndex)
            {

                case 0: //Filtrar por nombre
                    ListadoContactos = ListadoContactos.Where(l => l.Nombre.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 1://Filtrar por telefono
                    ListadoContactos = ListadoContactos.Where(l => l.Telefono.Contains(CriterioTextBox.Text)).ToList();
                    break;

                case 2://Filtrar por celular
                    ListadoContactos = ListadoContactos.Where(l => l.Celular.Contains(CriterioTextBox.Text)).ToList();
                    break;

                case 3: //Filtrar por Correo
                    ListadoContactos = ListadoContactos.Where(l => l.Correo.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 4: //Filtrar por Direccion
                    ListadoContactos = ListadoContactos.Where(l => l.Direccion.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 5: //Filtrar por Nota
                    ListadoContactos = ListadoContactos.Where(l => l.Nota.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;
            }

            ContactosDataGridView.DataSource = null;
            ContactosDataGridView.DataSource = ListadoContactos;
            ContactosDataGridView.ClearSelection();
            ContactosDataGridView.Columns[0].Visible = false;
        }


        private void cContactos_Load(object sender, EventArgs e)
        {
            FiltroComboBox.SelectedIndex = 0;
        }

        private void cContactos_Activated(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CriterioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }

        private void ContactosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListadoContactos.Count > 0)
            {
                if (ContactosDataGridView.CurrentRow.Index >= 0)
                {
                    int IdContactoSleccionado = Convert.ToInt32(ContactosDataGridView.CurrentRow.Cells["ContactoId"].Value);
                    rContactos rC = new rContactos(IdContactoSleccionado);
                    rC.ShowDialog();
                }
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            rContactos rC = new rContactos(0);
            rC.ShowDialog();
        }
    }
}
