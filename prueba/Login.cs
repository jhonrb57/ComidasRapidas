using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prueba
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if(txtuser.Text.Trim() == "" || txtpassword.Text.Trim() == "")
            {
                MessageBox.Show("Por favor escriba usuario y/o password");
                return;
            }

            try
            {
                //Crear conexión
                SqlConnection conexionConnection;
                conexionConnection = new SqlConnection("Data Source=DESKTOP-EG9BK65;Initial Catalog=ComidasRapidas;User ID=sa;Password=Bogota.2021");

                string query = "Select * from Usuario where Usuario = @usuario and Password = @password";
                SqlCommand comand = new SqlCommand(query, conexionConnection);
                comand.Parameters.AddWithValue("@usuario", txtuser.Text);
                comand.Parameters.AddWithValue("@password", txtpassword.Text);
                conexionConnection.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(comand);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conexionConnection.Close();
                int contar = ds.Tables[0].Rows.Count;
                if(contar == 1)
                {
                    //MessageBox.Show("¡Ingreso exitoso!");
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.lblusuario.Text = "Usuario: " + txtuser.Text;
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Ingreso fallido");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
