﻿using System;
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
                    //t.DataDevolucao = DateTime.Parse(reader["DataDevolucao"].ToString());
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

        public int Insert(Termo_Emprestimo t)
        {
            string query = "INSERT INTO Termo_de_Emprestimo(DataRetirada, Rg, CodEquipamento) VALUES(@DataRetirada,  @Rg,  @CodEquipamento)";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@DataRetirada", t.DataRetirada),
                                                  new SqlParameter("@Rg", t.Rg),
                                                  new SqlParameter("@CodEquipamento", t.CodEquipamento));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Update(Termo_Emprestimo t)
        {
            string query = "UPDATE Movimentacao SET DataRetirada = @dataRetirada, DataDevolucao = @dataDevolucao, Rg = @rg, CodEquipamento = @codEquipamento";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@DataRetirada", t.DataRetirada),
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
