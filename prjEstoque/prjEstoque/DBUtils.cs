using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque
{
    class DBUtils
    {
        private SqlConnection conn = null;
        public DBUtils()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
        public void OpenConnection()
        {
            if(conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public void CallExecuteNonQuery(string query)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    OpenConnection();
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch(SqlException sqlex)
            {

                throw new Exception("Erro ao executar o comando!\n'" + sqlex + "'");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public SqlDataReader CallExecuteReader(string query)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    OpenConnection();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            catch (SqlException sqlex)
            {

                throw new Exception("Erro ao executar o comando!\n'" + sqlex + "'");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        ~DBUtils()
        {
            conn.Dispose();
        }
    }
}
