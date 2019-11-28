using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class CTRL_Termo_Emprestimo
    {
        private MODEL_Termo_Emprestimo modelTE;

        public CTRL_Termo_Emprestimo()
        {
            modelTE = new MODEL_Termo_Emprestimo();
        }

        public List<Termo_Emprestimo> GetAll()
        {
            return modelTE.GetAll();
        }

        public TermoEquipamento GetTermo(int cod)
        {
            return modelTE.GetTermo(cod);
        }

        public int Insert(Termo_Emprestimo c)
        {
            return modelTE.Insert(c);
        }

        public int Update(Termo_Emprestimo c)
        {
            return modelTE.Update(c);
        }

        public int Delete(int cod)
        {
            return modelTE.Delete(cod);
        }
    }
}
