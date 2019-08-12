using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class BUS_Composicao
    {
        private MODEL_Composicao comp = null;

        public BUS_Composicao()
        {
            comp = new MODEL_Composicao();
        }

        public List<Composicao> GetAll()
        {
            return comp.GetAll();
        }

        public bool Insert(Composicao c)
        {
            return comp.Insert(c);
        }

        public bool Update(Composicao c)
        {
            return comp.Update(c);
        }

        public bool Delete(int cod)
        {
            return comp.Delete(cod);
        }
    }
}
