using AgengaYDirectorioTelefonico.BLL;
using AgengaYDirectorioTelefonico.Entidades;
using AgengaYDirectorioTelefonico.UI.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AgengaYDirectorioTelefonico.UI.Consultas
{
    public partial class cEventos : Form
    {
        public List<Eventos> ListadoEventos { get; private set; }
        public List<EventosC> ListadoEventosC { get; private set; }

        public class EventosC
        {
            public int EventoId { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public string Hora { get; set; }
            public string Nota { get; set; }

            public EventosC()
            {
                EventoId = 0;
                Descripcion = string.Empty;
                Fecha = DateTime.Now;
                Hora = string.Empty;
                Nota = string.Empty;
            }
        }


        private void CargarLista() // Funcion que intercambia el codigo de la categoria del producto porel nombre de la categoria
        {

            foreach (var item in ListadoEventos)
            {
                EventosC e = new EventosC();

                e.EventoId = item.EventoId;
                e.Fecha = item.Fecha;
                switch (item.Hora)
                {
                    case 0:
                        e.Hora = "12:00 A.M.";
                        break;

                    case 1:
                        e.Hora = "1:00 A.M.";
                        break;

                    case 2:
                        e.Hora = "2:00 A.M.";
                        break;

                    case 3:
                        e.Hora = "3:00 A.M.";
                        break;

                    case 4:
                        e.Hora = "4:00 A.M.";
                        break;

                    case 5:
                        e.Hora = "5:00 A.M.";
                        break;

                    case 6:
                        e.Hora = "6:00 A.M.";
                        break;

                    case 7:
                        e.Hora = "7:00 A.M.";
                        break;

                    case 8:
                        e.Hora = "8:00 A.M.";
                        break;

                    case 9:
                        e.Hora = "9:00 A.M.";
                        break;

                    case 10:
                        e.Hora = "10:00 A.M.";
                        break;

                    case 11:
                        e.Hora = "11:00 A.M.";
                        break;

                    case 12:
                        e.Hora = "12:00 P.M.";
                        break;

                    case 13:
                        e.Hora = "1:00 P.M.";
                        break;

                    case 14:
                        e.Hora = "2:00 P.M.";
                        break;

                    case 15:
                        e.Hora = "3:00 P.M.";
                        break;

                    case 16:
                        e.Hora = "4:00 P.M.";
                        break;

                    case 17:
                        e.Hora = "5:00 P.M.";
                        break;

                    case 18:
                        e.Hora = "6:00 P.M.";
                        break;

                    case 19:
                        e.Hora = "7:00 P.M.";
                        break;

                    case 20:
                        e.Hora = "8:00 P.M.";
                        break;

                    case 21:
                        e.Hora = "9:00 P.M.";
                        break;

                    case 22:
                        e.Hora = "10:00 P.M.";
                        break;

                    case 23:
                        e.Hora = "11:00 P.M.";
                        break;

                }
                e.Descripcion = item.Descripcion;
                e.Nota = item.Nota;

                ListadoEventosC.Add(e);
            }
        }

        private void Buscar()
        {
            RepositorioBase<Eventos> Repositorio = new RepositorioBase<Eventos>();
            ListadoEventos = new List<Eventos>();
            ListadoEventos = Repositorio.GetList(p => true);

            ListadoEventosC = new List<EventosC>();

            CargarLista();

            if (RangoCheckBox.Checked == true)
            {
                ListadoEventosC = ListadoEventosC.Where(l => l.Fecha.Date >= DesdeDateTimePicker.Value.Date && l.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
                ListadoEventosC = ListadoEventosC.Where(l => l.Fecha.Date == DesdeDateTimePicker.Value.Date).ToList();

            switch (FiltroComboBox.SelectedIndex)
            {

                case 0: //Filtrar por fecha
                    ListadoEventosC = ListadoEventosC.Where(l => l.Hora.Contains(HoraComboBox.SelectedItem.ToString())).ToList();
                    break;

                case 1://Filtrar por descripcion
                    ListadoEventosC = ListadoEventosC.Where(l => l.Descripcion.Contains(CriterioTextBox.Text)).ToList();
                    break;

                case 2://Filtrar por nota
                    ListadoEventosC = ListadoEventosC.Where(l => l.Nota.Contains(CriterioTextBox.Text)).ToList();
                    break;

            }

            EventosDataGridView.DataSource = null;
            EventosDataGridView.DataSource = ListadoEventosC;
            EventosDataGridView.ClearSelection();
            EventosDataGridView.Columns[0].Visible = false;
            EventosDataGridView.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public cEventos()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            rEventos rE = new rEventos(0);
            rE.ShowDialog();
        }

        private void RangoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RangoCheckBox.Checked == true)
            {
                DesdeLabel.Text = "Desde";
                HastaDateTimePicker.Enabled = true;
            }

            else
            {
                DesdeLabel.Text = "Fecha";
                HastaDateTimePicker.Enabled = false;
            }

            Buscar();
        }

        private void cEventos_Load(object sender, EventArgs e)
        {
            FiltroComboBox.SelectedIndex = 1;
        }

        private void cEventos_Activated(object sender, EventArgs e)
        {
            HoraComboBox.SelectedIndex = 0;
            Buscar();
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FiltroComboBox.SelectedIndex == 0)
            {
                CriterioTextBox.Visible = false;
                CriterioTextBox.Text = string.Empty;
                HoraComboBox.SelectedIndex = -1;
                HoraComboBox.Visible = true;
            }
            else
            {
                CriterioTextBox.Visible = true;
                CriterioTextBox.Text = string.Empty;
                HoraComboBox.SelectedIndex = -1;
                HoraComboBox.Visible = false;
            }

        }

        private void EventosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ListadoEventosC.Count > 0)
            {
                if (EventosDataGridView.CurrentRow.Index >= 0)
                {
                    int IdEventoSleccionado = Convert.ToInt32(EventosDataGridView.CurrentRow.Cells["EventoId"].Value);
                    rEventos rE = new rEventos(IdEventoSleccionado);
                    rE.ShowDialog();
                }
            }
        }

        private void HoraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(HoraComboBox.Visible == true)
                Buscar();
        }

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CriterioTextBox.Visible == true)
                Buscar();
        }

        private void DesdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void HastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
