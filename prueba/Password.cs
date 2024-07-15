using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            if (txtactual.Text.Trim() == "" || txtnueva.Text.Trim() == "" || txtrepetir.Text.Trim() == "")
            {
                MessageBox.Show("Por favor escriba contraseña actual y/o nueva y/o repitala");
                return;
            }

            try
            {
                //Crear conexión
                SqlConnection conexionConnection;
                conexionConnection = new SqlConnection("Data Source=DESKTOP-EG9BK65;Initial Catalog=ComidasRapidas;User ID=sa;Password=Bogota.2021");

                string query = "Select * from Usuario where Password = @password";
                SqlCommand comand = new SqlCommand(query, conexionConnection);
                comand.Parameters.AddWithValue("@password", txtactual.Text);
                conexionConnection.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(comand);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conexionConnection.Close();
                int contar = ds.Tables[0].Rows.Count;
                if (contar == 1)
                {
                    //MessageBox.Show("¡Coincide contraseña!");
                    this.Hide();
                    Form1 inicio = new Form1();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("Ingreso fallido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if ()
            //{

            //}
        }
    }
}
