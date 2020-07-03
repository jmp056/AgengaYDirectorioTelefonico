using AgengaYDirectorioTelefonico.UI.Consultas;
using AgengaYDirectorioTelefonico.UI.Registros;
using System;
using System.Windows.Forms;

namespace AgengaYDirectorioTelefonico
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cEventos rE = new cEventos();
            rE.ShowDialog();
        }
    }
}
