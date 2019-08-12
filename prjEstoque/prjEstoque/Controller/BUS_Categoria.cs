using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class BUS_Categoria
    {
        private MODEL_Categoria cat = null;

        public BUS_Categoria()
        {
            cat = new MODEL_Categoria();
        }

        public List<Categoria> GetAll()
        {
            return cat.GetAll();
        }

        public bool Insert(Categoria c)
        {
            return cat.Insert(c);
        }

        public bool Update(Categoria c)
        {
            return cat.Update(c);
        }

        public bool Delete(int cod)
        {
            return cat.Delete(cod);
        }
    }
}
