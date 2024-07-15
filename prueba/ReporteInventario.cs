using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prueba
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            SqlConnection conexionConnection;
            conexionConnection = new SqlConnection("Data Source=DESKTOP-EG9BK65;Initial Catalog=ComidasRapidas;User ID=sa;Password=Bogota.2021");
            conexionConnection.Open();

            string query = "Select NombreProducto, Cantidad from Inventario order by NombreProducto";
            SqlCommand comand = new SqlCommand(query, conexionConnection);
            SqlDataAdapter sda = new SqlDataAdapter(comand);

            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
