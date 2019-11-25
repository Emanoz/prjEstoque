using prjEstoque.Entity;
using prjEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Controller
{
    class CTRL_Usuario
    {
        private MODEL_Usuario mUsu;
        public CTRL_Usuario()
        {
            mUsu = new MODEL_Usuario();
        }

        public Usuario Logar(string usuario, string senha)
        {
            return mUsu.Logar(usuario, senha);
        }

        public Usuario GetById(int cod)
        {
            return mUsu.GetById(cod);
        }
    }
}
