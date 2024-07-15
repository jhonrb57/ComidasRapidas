using System;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
        }

        private void entradaDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaDatos entradaDatos = new EntradaDatos();
            entradaDatos.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteInventario reporte = new ReporteInventario();
            reporte.Show();
        }

        private void comandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            comanda.Show();
        }

        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            password.lblus.Text = this.lblusuario.Text;
            password.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
