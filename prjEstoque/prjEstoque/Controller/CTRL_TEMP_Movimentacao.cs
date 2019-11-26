using prjEstoque.Entity;
using prjEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Controller
{
    public class CTRL_TEMP_Movimentacao
    {
        private MODEL_TEMP_Movimentacao mMov;

        public CTRL_TEMP_Movimentacao()
        {
            mMov = new MODEL_TEMP_Movimentacao();
        }

        public List<TEMP_Movimentacao> GetAll()
        {
            return mMov.GetAll();
        }

        
    }
}
