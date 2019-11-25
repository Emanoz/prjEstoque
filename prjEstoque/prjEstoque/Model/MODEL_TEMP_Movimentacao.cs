using prjEstoque.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Model
{
    public class MODEL_TEMP_Movimentacao
    {
        private DBUtils db;

        public MODEL_TEMP_Movimentacao()
        {
            db = new DBUtils();
        }

        public List<TEMP_Movimentacao> GetAll()
        {
            string query = "SELECT * FROM MostrarMovimentacao";
            List<TEMP_Movimentacao> list = new List<TEMP_Movimentacao>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    TEMP_Movimentacao c = new TEMP_Movimentacao();

                    c.Usuario = reader["NomeUsu"].ToString();
                    c.Equipamento = reader["NomeEquip"].ToString();
                    c.Estoque = reader["NomeLocal"].ToString();
                    c.TipoMov = reader["Estado"].ToString();
                    c.DataMov = DateTime.Parse(reader["dataMovimentacao"].ToString());

                    list.Add(c);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return list;
        }
    }
}
