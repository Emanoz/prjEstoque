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
    public partial class frmMoverParaEstoque : Form
    {
        private Usuario usu;
        private int codEquip;
        public frmMoverParaEstoque()
        {
            InitializeComponent();
        }

        public frmMoverParaEstoque(Equipamento e, Usuario usu)
        {
            InitializeComponent();
            txtDescricao.Text = e.Descricao;
            _txtEstado.Text = e.Estado;
            _txtNSerie.Text = e.NumSerie;
            _txtCategoria.Text = e.CodCategoria.ToString();
            _txtPertencente.Text = e.Pertencente;
            _txtPatrimonio.Text = e.Patrimonio;
            codEquip = e.CodEquipamento;
            this.usu = usu;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cbEstoque_DropDown(object sender, EventArgs e)
        {
            CTRL_Estoque cEst = new CTRL_Estoque();
            cbEstoque.DataSource = cEst.GetAll();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            CTRL_Movimentacao mov = new CTRL_Movimentacao();
            if (mov.Insert(new Movimentacao(usu.CodUsuario, codEquip, ((Estoque)cbEstoque.SelectedItem).CodEstoque, "Movimentação", DateTime.Now)) > 0)
                Close();
            else
                MessageBox.Show("O equipamento não foi movido devido a algum erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
