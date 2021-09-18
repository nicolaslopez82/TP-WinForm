using System;
using System.Text;
using System.Data.SqlClient;

namespace ConexionDataBase
{
    public class ConexionDataBase
    {
        private SqlConnection SqlConexion;
        private SqlCommand SqlCommand;
        private SqlDataReader reader;
        public SqlDataReader Lector
        {
            get { return reader; }
        }

        public ConexionDataBase()
        {
            SqlConexion = new SqlConnection(ConstantesDB.SQL_CONNECTION_CONEXION.Value);
            SqlCommand = new SqlCommand();
        }

        public void read()
        {
            SqlCommand.Connection = SqlConexion;
            try
            {
                SqlConexion.Open();
                reader = SqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throwSqlExeption(ex);
            }
        }

        public void executeQuery()
        {
            SqlCommand.Connection = SqlConexion;
            try
            {
                SqlConexion.Open();
                SqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throwSqlExeption(ex);
            }
        }

        public void setQuery(string query)
        {
            SqlCommand.CommandType = System.Data.CommandType.Text;
            SqlCommand.CommandText = query;
        }

        public void setParam(string key, object value)
        {
            SqlCommand.Parameters.AddWithValue(key, value);
        }

        public void closeConexion()
        {
            if (reader != null)
                reader.Close();
            SqlConexion.Close();
        }

        private void throwSqlExeption(SqlException ex) {

            StringBuilder errorMessages = new StringBuilder();

            for (int i = 0; i < ex.Errors.Count; i++)
            {
                errorMessages.Append("Index #" + i + "\n" +
                                    "Message: " + ex.Errors[i].Message + "\n" +
                                    "Error Number: " + ex.Errors[i].Number + "\n" +
                                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                    "Source: " + ex.Errors[i].Source + "\n" +
                                    "Procedure: " + ex.Errors[i].Procedure + "\n");
            }
            Console.WriteLine(errorMessages.ToString());
            throw new Exception("Ha ocurrido una excepción al intentar realizar la ejecucion SQL");
        }
    }
}
