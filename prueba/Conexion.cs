using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prueba
{
    public class Conexion
    {
        SqlConnection conexionConnection;

        public Conexion()
        {
            try
            {
                conexionConnection = new SqlConnection("Data Source=DESKTOP-EG9BK65;Initial Catalog=ComidasRapidas;User ID=sa;Password=Bogota.2021");
                conexionConnection.Open();
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Error en conexión a base de datos", "Error inesperado", MessageBoxButtons.OK);
            }
        }
    }
}
