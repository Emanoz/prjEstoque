using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class CTRL_Equipamento
    {
        private MODEL_Equipamento modelE;

        public CTRL_Equipamento()
        {
            modelE = new MODEL_Equipamento();
        }

        public List<Equipamento> GetAll()
        {
            return modelE.GetAll();
        }

        public int Insert(Equipamento c)
        {
            return modelE.Insert(c);
        }

        public int Update(Equipamento c)
        {
            return modelE.Update(c);
        }

        public int Delete(int cod)
        {
            return modelE.Delete(cod);
        }
    }
}
