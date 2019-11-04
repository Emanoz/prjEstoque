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
    public partial class frmRelatorio_Equipamento : Form
    {
        public int Index { get; set; }
        public frmRelatorio_Equipamento(int index)
        {
            InitializeComponent();
            Index = index;
        }

        private void frmRelatorio_Equipamento_Load(object sender, EventArgs e)
        {
            CTRL_Equipamento cEquip = new CTRL_Equipamento();
            Equipamento equip = new Equipamento();

            equip = cEquip.GetById(Index);

            _txtEstado.Text = equip.Estado;
            txtDescricao.Text = equip.Descricao;
            _txtNSerie.Text = equip.NumSerie;
            _txtCategoria.Text = equip.CodCategoria.ToString();
            _txtPertencente.Text = equip.Pertencente;
            _txtPatrimonio.Text = equip.Patrimonio;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrar_Termo_Click(object sender, EventArgs e)
        {
            CTRL_Termo_Emprestimo cTermo = new CTRL_Termo_Emprestimo();
            Termo_Emprestimo termo = new Termo_Emprestimo(dtpRetirada.Value, txtRg.Text, Index);

            if (cTermo.Insert(termo) <= 0)
                MessageBox.Show("Erro ao gerar relatorio!");
            else
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Util.LimparCampos(pnCampos.Controls);
        }
    }
}
