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
        public DBUtils()
        {
            
        }

        public void OpenConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public void CallExecuteNonQuery(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=PC-NANA\\SQLEXPRESS;Database=bdEstoque;Trusted_Connection=True;"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        OpenConnection(conn);
                        cmd.ExecuteNonQuery();
                        CloseConnection(conn);
                    }
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
                SqlConnection conn = new SqlConnection("Server=PC-NANA\\SQLEXPRESS;Database=bdEstoque;Trusted_Connection=True;");

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    OpenConnection(conn);
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
    }
}
