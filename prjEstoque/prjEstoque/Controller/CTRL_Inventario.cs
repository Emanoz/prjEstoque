using prjEstoque.Entity;
using prjEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Controller
{
    class CTRL_Inventario
    {
        private MODEL_Inventario mInv;

        public CTRL_Inventario()
        {
            mInv = new MODEL_Inventario();
        }

        public List<Inventario> GetAll()
        {
            return mInv.GetAll();
        }
    }
}
