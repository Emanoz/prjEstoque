using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Termo_Emprestimo
    {
        private DBUtils db;

        public MODEL_Termo_Emprestimo()
        {
            db = new DBUtils();
        }

        public List<Termo_Emprestimo> GetAll()
        {
            string query = "SELECT * FROM Termo_de_Emprestimo";
            List<Termo_Emprestimo> list = new List<Termo_Emprestimo>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    Termo_Emprestimo t = new Termo_Emprestimo();

                    t.CodTermo = int.Parse(reader["CodrTermo"].ToString());
                    t.DataRetirada = DateTime.Parse(reader["DataRetirada"].ToString());
                    t.CaminhoDigitalizado = reader["CaminhoDigitalizado"].ToString();
                    t.Rg = reader["Rg"].ToString(); ;
                    t.DataDevolucao = DateTime.Parse(reader["DataDevolucao"].ToString());
                    t.CodEquipamento = int.Parse(reader["CodEquipamento"].ToString());

                    list.Add(t);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return list;
        }

        public void Insert(Termo_Emprestimo t)
        {
            string query = "INSERT INTO Termo_de_Emprestimo VALUES(@DataRetirada, @CaminhoDigitalizado, @Rg, @DataDevolucao, @CodEquipamento)";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@DataRetirada", t.DataRetirada),
                                                  new SqlParameter("@CaminhoDigitalizado", t.CaminhoDigitalizado),
                                                  new SqlParameter("@Rg", t.Rg),
                                                  new SqlParameter("@DataDevolucao", t.DataDevolucao),
                                                  new SqlParameter("@CodEquipamento", t.CodEquipamento)) == 0)
                    throw new Exception("Nenhuma linha foi cadastrada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Update(Termo_Emprestimo t)
        {
            string query = "UPDATE Movimentacao SET DataRetirada = @dataRetirada, CaminhoDigitalizado = @caminhoDigitalizado, Rg = @rg, DataDevolucao = @dataDevolucao, CodEquipamento = @codEquipamento";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@DataRetirada", t.DataRetirada),
                                                  new SqlParameter("@CaminhoDigitalizado", t.CaminhoDigitalizado),
                                                  new SqlParameter("@Rg", t.Rg),
                                                  new SqlParameter("@DataDevolucao", t.DataDevolucao),
                                                  new SqlParameter("@CodEquipamento", t.CodEquipamento)) == 0)
                    throw new Exception("Nenhuma linha foi alterada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(int cod)
        {
            string query = "DELETE FROM Termo_de_Emprestimo WHERE CodTermo = @codTermo";
            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@codTermo", cod)) == 0)
                    throw new Exception("Nenhuma linha foi excluída");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
