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
    public partial class frmEditarBase : Form
    {
        private int index;
        public frmEditarBase(Equipamento e)
        {
            InitializeComponent();

            txtDescricao.Text = e.Descricao;
            txtEstado.Text = e.Estado;
            cbCategoria.Text = e.CodCategoria.ToString();
            txtNSerie.Text = e.NumSerie;
            txtPertencente.Text = e.Pertencente;
            txtPatrimonio.Text = e.Patrimonio;
            index = e.CodEquipamento;
        }

        private void btnLimpar_Equi_Click(object sender, EventArgs e)
        {
            Util.LimparCampos(pnEquipamento.Controls);
        }

        private void btnCadastrar_Equi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Têm certeza que deseja realizar estas alterações?", "Atenção", MessageBoxButtons.YesNo, 
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CTRL_Equipamento cEquip = new CTRL_Equipamento();
                if (cEquip.Update(new Equipamento(index, txtDescricao.Text, txtNSerie.Text, txtEstado.Text, int.Parse(cbCategoria.Text),
                                              txtPertencente.Text, txtPatrimonio.Text)) == 0)
                    MessageBox.Show("Erro ao atualizar campos. Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    Dispose();
                }   

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
