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

        public List<Categoria> GetCategoria()
        {
            return modelC.GetCategoria();
        }

        public int Insert(Categoria c)
        {
            return modelC.Insert(c);
        }

        public int Update(Categoria c)
        {
            return modelC.Update(c);
        }

        public int Delete(int cod)
        {
            return modelC.Delete(cod);
        }
    }
}
