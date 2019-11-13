using prjEstoque.Controller;
using prjEstoque.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEstoque.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CTRL_Usuario cUsu = new CTRL_Usuario();

            Usuario usu = cUsu.Logar(txtUsuario.Text, txtSenha.Text);
            if (usu != null)
            {
                using (var frm = new frmPrincipal(usu))
                    frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }
    }
}
