using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class BUS_Fornecedor
    {
        private MODEL_Fornecedor forn = null;

        public BUS_Fornecedor()
        {
            forn = new MODEL_Fornecedor();
        }

        public List<Fornecedor> GetAll()
        {
            return forn.GetAll();
        }

        public bool Insert(Fornecedor f)
        {
            return forn.Insert(f);
        }

        public bool Update(Fornecedor f)
        {
            return forn.Update(f);
        }

        public bool Delete(int cod)
        {
            return forn.Delete(cod);
        }
    }
}
