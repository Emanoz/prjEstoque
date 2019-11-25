using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class CTRL_Estoque
    {
        private MODEL_Estoque modelE;

        public CTRL_Estoque()
        {
            modelE = new MODEL_Estoque();
        }

        public List<Estoque> GetAll()
        {
            return modelE.GetAll();
        }

        public Estoque GetById(int cod)
        {
            return modelE.GetById(cod);
        }

        public int Insert(Estoque c)
        {
            return modelE.Insert(c);
        }

        public int Update(Estoque c)
        {
            return modelE.Update(c);
        }

        public int Delete(int cod)
        {
            return modelE.Delete(cod);
        }
    }
}
