using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Equipamento
    {
        private DBUtils db;

        public MODEL_Equipamento()
        {
            db = new DBUtils();
        }

        public List<Equipamento> GetAll()
        {
            string query = "SELECT * FROM Equipamento";
            List<Equipamento> list = new List<Equipamento>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    Equipamento e = new Equipamento();

                    e.CodEquipamento = int.Parse(reader["CodEquipamento"].ToString());
                    e.Descricao = reader["Descricao"].ToString();
                    e.NumSerie = reader["NumSerie"].ToString();
                    e.Estado = reader["Estado"].ToString();
                    e.CodCategoria = int.Parse(reader["CodCategoria"].ToString());
                    e.Pertencente = reader["Pertencente"].ToString();
                    e.Patrimonio = reader["Patrimonio"].ToString();

                    list.Add(e);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return list;
        }

        public Equipamento GetById(int cod)
        {
            string query = "SELECT * FROM Equipamento WHERE CodEquipamento = @codEquipamento";
            Equipamento e = new Equipamento();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query, new SqlParameter("@codEquipamento", cod));
                reader.Read();

                e.Descricao = reader["Descricao"].ToString();
                e.NumSerie = reader["NumSerie"].ToString();
                e.Estado = reader["Estado"].ToString();
                e.CodCategoria = int.Parse(reader["CodCategoria"].ToString());
                e.Pertencente = reader["Pertencente"].ToString();
                e.Patrimonio = reader["Patrimonio"].ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return e;
        }

        public int Insert(Equipamento e)
        {
            string querySelect = "SELECT * FROM Equipamento WHERE NumSerie = @numSerie OR Patrimonio = @patrimonio";
            string queryInsert = "INSERT INTO Equipamento VALUES(@descricao, @numSerie, @estado, @codCategoria, @pertencente, @patrimonio)";

            try
            {
                SqlDataReader reader = db.CallExecuteReader(querySelect, new SqlParameter("@numSerie", e.NumSerie),
                                                            new SqlParameter("@patrimonio", e.Patrimonio));
                if (reader.Read())
                    return -1;
                else
                    return db.CallExecuteNonQuery(queryInsert, new SqlParameter("@descricao", e.Descricao),
                                                  new SqlParameter("@numSerie", e.NumSerie),
                                                  new SqlParameter("@estado", e.Estado),
                                                  new SqlParameter("@codCategoria", e.CodCategoria),
                                                  new SqlParameter("@pertencente", e.Pertencente),
                                                  new SqlParameter("@patrimonio", e.Patrimonio));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Update(Equipamento e)
        {
            string query = "UPDATE Equipamento SET Descricao = @descricao, NumSerie = @numSerie, Estado = @estado, CodCategoria = @codCategoria, Pertencente = @pertencente, Patrimonio = @patrimonio WHERE CodEquipamento = @codEquip";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@descricao", e.Descricao),
                                                  new SqlParameter("@numSerie", e.NumSerie),
                                                  new SqlParameter("@estado", e.Estado),
                                                  new SqlParameter("@codCategoria", e.CodCategoria),
                                                  new SqlParameter("@pertencente", e.Pertencente),
                                                  new SqlParameter("@patrimonio", e.Patrimonio),
                                                  new SqlParameter("@codEquip", e.CodEquipamento));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Delete(int cod)
        {
            string query = "DELETE FROM Equipamento WHERE CodEquipamento = @codEquipamento";
            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@codEquipamento", cod));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
