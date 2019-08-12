using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class BUS_Produto
    {
        private MODEL_Produto prod = null;

        public BUS_Produto()
        {
            prod = new MODEL_Produto();
        }

        public List<Produto> GetAll()
        {
            return prod.GetAll();
        }

        public bool Insert(Produto p)
        {
            return prod.Insert(p);
        }

        public bool Update(Produto p)
        {
            return prod.Update(p);
        }

        public bool Delete(int cod)
        {
            return prod.Delete(cod);
        }
    }
}
