using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Movimentacao
    {
        private DBUtils db;

        public MODEL_Movimentacao()
        {
            db = new DBUtils();
        }

        public List<Movimentacao> GetAll()
        {
            string query = "SELECT * FROM Movimentacao";
            List<Movimentacao> list = new List<Movimentacao>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    Movimentacao m = new Movimentacao();

                    m.CodMovimentacao = int.Parse(reader["CodMovimentacao"].ToString());
                    m.CodUsuario = int.Parse(reader["CodUsuario"].ToString());
                    m.CodEquipamento = int.Parse(reader["CodEquipamento"].ToString());
                    m.CodEstoque = int.Parse(reader["CodEstoque"].ToString());;
                    m.Estado = reader["Estado"].ToString();
                    m.DataMovimentacao = DateTime.Parse(reader["DataMovimentacao"].ToString());

                    list.Add(m);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return list;
        }

        public void Insert(Movimentacao m)
        {
            string query = "INSERT INTO Movimentacao VALUES(@codUsuario, @codEquipamento, @codEstoque, @estado, @dataMovimentacao)";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@codUsuario", m.CodUsuario),
                                                  new SqlParameter("@codEquipamento", m.CodEquipamento),
                                                  new SqlParameter("@codEstoque", m.CodEstoque),
                                                  new SqlParameter("@estado", m.Estado),
                                                  new SqlParameter("@dataMovimentacao", m.DataMovimentacao)) == 0)
                    throw new Exception("Nenhuma linha foi cadastrada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Update(Movimentacao m)
        {
            string query = "UPDATE Movimentacao SET CodUsuario = @codUsuario, CodEquipamento = @codEquipamento, CodEstoque = @codEstoque, Estado = @estado, DataMovimentacao = @dataMovimentacao";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@codUsuario", m.CodUsuario),
                                                  new SqlParameter("@codEquipamento", m.CodEquipamento),
                                                  new SqlParameter("@codEstoque", m.CodEstoque),
                                                  new SqlParameter("@estado", m.Estado),
                                                  new SqlParameter("@dataMovimentacao", m.DataMovimentacao)) == 0)
                    throw new Exception("Nenhuma linha foi alterada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(int cod)
        {
            string query = "DELETE FROM Movimentacao WHERE CodMovimentacao = @codMovimentacao";
            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@codMovimentacao", cod)) == 0)
                    throw new Exception("Nenhuma linha foi excluída");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
