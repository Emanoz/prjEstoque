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

        public void Insert(Termo_Emprestimo c)
        {
            modelTE.Insert(c);
        }

        public void Update(Termo_Emprestimo c)
        {
            modelTE.Update(c);
        }

        public void Delete(int cod)
        {
            modelTE.Delete(cod);
        }
    }
}
