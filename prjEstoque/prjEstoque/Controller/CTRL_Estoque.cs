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

        public void Insert(Estoque c)
        {
            modelE.Insert(c);
        }

        public void Update(Estoque c)
        {
            modelE.Update(c);
        }

        public void Delete(int cod)
        {
            modelE.Delete(cod);
        }
    }
}
