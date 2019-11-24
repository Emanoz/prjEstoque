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

        public int Insert(Movimentacao c)
        {
            return modelM.Insert(c);
        }
    }
}
