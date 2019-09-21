using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Model;
using prjEstoque.Entity;

namespace prjEstoque.Controller
{
    class CTRL_Categoria
    {
        private MODEL_Categoria modelC;

        public CTRL_Categoria()
        {
            modelC = new MODEL_Categoria();
        }

        public List<Categoria> GetAll()
        {
            return modelC.GetAll();
        }

        public void Insert(Categoria c)
        {
            modelC.Insert(c);
        }

        public void Update(Categoria c)
        {
            modelC.Update(c);
        }

        public void Delete(int cod)
        {
            modelC.Delete(cod);
        }
    }
}
