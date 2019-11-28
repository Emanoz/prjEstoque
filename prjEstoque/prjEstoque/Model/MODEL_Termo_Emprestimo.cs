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

                    t.CodTermo = int.Parse(reader["CodTermo"].ToString());
                    t.DataRetirada = DateTime.Parse(reader["DataRetirada"].ToString());
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

        public TermoEquipamento GetTermo(int cod)
        {
            string query = "select t.Rg RG, t.DataRetirada Retirada, e.Descricao Descricao, e.Patrimonio Patrimonio, e.NumSerie SN, t.DataDevolucao Devolucao " +
                            "from TERMO_DE_EMPRESTIMO t inner join EQUIPAMENTO e " +
                            "on t.CodEquipamento = e.CodEquipamento where t.CodTermo = @codTermo";

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query, new SqlParameter("@codTermo", cod));
                reader.Read();

                TermoEquipamento t = new TermoEquipamento();

                t.DtpRetirada = DateTime.Parse(reader["Retirada"].ToString());
                t.Rg = reader["Rg"].ToString(); ;
                t.DtpDevolucao = DateTime.Parse(reader["Devolucao"].ToString());
                t.Descricao = reader["Descricao"].ToString();
                t.Patrimonio = reader["Patrimonio"].ToString();
                t.NSerie = reader["SN"].ToString();

                reader.Close();
                return t;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Insert(Termo_Emprestimo t)
        {
            string query = "INSERT INTO Termo_de_Emprestimo(DataRetirada, Rg, DataDevolucao, CodEquipamento) VALUES(@DataRetirada,  @Rg, @dataDevolucao, @CodEquipamento)";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@DataRetirada", t.DataRetirada),
                                                  new SqlParameter("@Rg", t.Rg),
                                                  new SqlParameter("@dataDevolucao", t.DataDevolucao),
                                                  new SqlParameter("@CodEquipamento", t.CodEquipamento));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Update(Termo_Emprestimo t)
        {
            string query = "UPDATE Termo_de_Emprestimo SET DataRetirada = @dataRetirada, DataDevolucao = @dataDevolucao, Rg = @rg, CodEquipamento = @codEquipamento WHERE CodTermo = @codTermo";

            try
            {
                    return db.CallExecuteNonQuery(query, new SqlParameter("@codTermo", t.CodTermo),
                                                  new SqlParameter("@DataRetirada", t.DataRetirada),
                                                  new SqlParameter("@dataDevolucao", t.DataDevolucao),
                                                  new SqlParameter("@Rg", t.Rg),
                                                  new SqlParameter("@CodEquipamento", t.CodEquipamento));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Delete(int cod)
        {
            string query = "DELETE FROM Termo_de_Emprestimo WHERE CodTermo = @codTermo";
            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@codTermo", cod));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
