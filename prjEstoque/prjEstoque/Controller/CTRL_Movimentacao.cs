using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class CTRL_Movimentacao
    {
        private MODEL_Movimentacao modelM;

        public CTRL_Movimentacao()
        {
            modelM = new MODEL_Movimentacao();
        }

        public List<Movimentacao> GetAll()
        {
            return modelM.GetAll();
        }

        public void Insert(Movimentacao c)
        {
            modelM.Insert(c);
        }

        public void Update(Movimentacao c)
        {
            modelM.Update(c);
        }

        public void Delete(int cod)
        {
            modelM.Delete(cod);
        }
    }
}
