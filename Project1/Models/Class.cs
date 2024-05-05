using System.Data;
using System.Data.SqlClient;

namespace Models
{
    public class Class
    {
        private SqlConnection conexion = new SqlConnection("Data Source=NAVARRETE\\SQLEXPRESS;Initial Catalog=Proyecto_DAWA;Integrated Security=True");
        public SqlConnection OpenConnection()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CloseConnection()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
        //Coneccion actual
        public SqlConnection GetCurrentConnection()
        {
            return conexion;
        }
    }
}
