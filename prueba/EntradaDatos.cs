using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prueba
{
    public partial class EntradaDatos : Form
    {
        public EntradaDatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EntradaDatos_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexionConnection;
            conexionConnection = new SqlConnection("Data Source=DESKTOP-EG9BK65;Initial Catalog=ComidasRapidas;User ID=sa;Password=Bogota.2021");
            conexionConnection.Open();
            int flag = 0;

            if (Int32.Parse(textBox1.Text) > 0)//Piñas
            {
                string cantidadsql = "Select Cantidad from Inventario where NombreProducto = '" + label1.Text + "'";
                SqlCommand comand = new SqlCommand(cantidadsql, conexionConnection);
                string cantidad = (string)comand.ExecuteScalar();
                int cantidadFinal = Int32.Parse(cantidad) + Int32.Parse(textBox1.Text);
                string cadena = "Update Inventario set Cantidad = '" + cantidadFinal.ToString() + "' where NombreProducto = '" + label1.Text + "'";
                SqlCommand comando = new SqlCommand(cadena, conexionConnection);
                flag = comando.ExecuteNonQuery();
            }

            if (Int32.Parse(textBox2.Text) > 0)//Papa
            {
                string cantidadsql = "Select Cantidad from Inventario where NombreProducto = '" + label3.Text + "'";
                SqlCommand comand = new SqlCommand(cantidadsql, conexionConnection);
                string cantidad = (string)comand.ExecuteScalar();
                int cantidadFinal = Int32.Parse(cantidad) + Int32.Parse(textBox2.Text);
                string cadena = "Update Inventario set Cantidad = '" + cantidadFinal.ToString() + "' where NombreProducto = '" + label3.Text + "'";
                SqlCommand comando = new SqlCommand(cadena, conexionConnection);
                flag = comando.ExecuteNonQuery();
            }

            if (Int32.Parse(textBox3.Text) > 0)//Queso
            {
                string cantidadsql = "Select Cantidad from Inventario where NombreProducto = '" + label4.Text + "'";
                SqlCommand comand = new SqlCommand(cantidadsql, conexionConnection);
                string cantidad = (string)comand.ExecuteScalar();
                int cantidadFinal = Int32.Parse(cantidad) + Int32.Parse(textBox3.Text);
                string cadena = "Update Inventario set Cantidad = '" + cantidadFinal.ToString() + "' where NombreProducto = '" + label4.Text + "'";
                SqlCommand comando = new SqlCommand(cadena, conexionConnection);
                flag = comando.ExecuteNonQuery();
            }

            if (Int32.Parse(textBox4.Text) > 0)//Pitillos
            {
                string cantidadsql = "Select Cantidad from Inventario where NombreProducto = '" + label5.Text + "'";
                SqlCommand comand = new SqlCommand(cantidadsql, conexionConnection);
                string cantidad = (string)comand.ExecuteScalar();
                int cantidadFinal = Int32.Parse(cantidad) + Int32.Parse(textBox4.Text);
                string cadena = "Update Inventario set Cantidad = '" + cantidadFinal.ToString() + "' where NombreProducto = '" + label5.Text + "'";
                SqlCommand comando = new SqlCommand(cadena, conexionConnection);
                flag = comando.ExecuteNonQuery();
            }

            if (Int32.Parse(textBox5.Text) > 0)//Servilletas
            {
                string cantidadsql = "Select Cantidad from Inventario where NombreProducto = '" + label6.Text + "'";
                SqlCommand comand = new SqlCommand(cantidadsql, conexionConnection);
                string cantidad = (string)comand.ExecuteScalar();
                int cantidadFinal = Int32.Parse(cantidad) + Int32.Parse(textBox5.Text);
                string cadena = "Update Inventario set Cantidad = '" + cantidadFinal.ToString() + "' where NombreProducto = '" + label6.Text + "'";
                SqlCommand comando = new SqlCommand(cadena, conexionConnection);
                flag = comando.ExecuteNonQuery();
            }

            if(flag == 0)
            {
                MessageBox.Show("Los datos no se actualizaron, por favor intenta de nuevo");
                conexionConnection.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos actualizados");
                conexionConnection.Close();
                this.Close();
            }
        }
    }
}
