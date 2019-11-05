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
        public object Entity { get; set; }
        public frmEditarBase(object e)
        {
            InitializeComponent();
            Entity = e;
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

        private void frmEditarBase_Load(object sender, EventArgs e)
        {
            if(Entity is Equipamento)
            {
                txtDescricao.Text = ((Equipamento)Entity).Descricao;
                txtEstado.Text = ((Equipamento)Entity).Estado;
                cbCategoria.Text = ((Equipamento)Entity).CodCategoria.ToString();
                txtNSerie.Text = ((Equipamento)Entity).NumSerie;
                txtPertencente.Text = ((Equipamento)Entity).Pertencente;
                txtPatrimonio.Text = ((Equipamento)Entity).Patrimonio;
                index = ((Equipamento)Entity).CodEquipamento;

                pnEquipamento.BringToFront();
            }
            else if(Entity is Termo_Emprestimo)
            {
                txtRg.Text = ((Termo_Emprestimo)Entity).Rg;
                dtpRetirada.Value = ((Termo_Emprestimo)Entity).DataRetirada;
                if(((Termo_Emprestimo)Entity).DataDevolucao != DateTime.MinValue)
                    dtpDevolucao.Value = ((Termo_Emprestimo)Entity).DataDevolucao;

                CTRL_Equipamento cEquip = new CTRL_Equipamento();
                Equipamento equip = new Equipamento();

                equip = cEquip.GetById(((Termo_Emprestimo)Entity).CodEquipamento);
                cbDescricao.Text = equip.Descricao;
                _txtEstado.Text = equip.Estado;
                _txtNSerie.Text = equip.NumSerie;
                _txtCategoria.Text = equip.CodCategoria.ToString();
                _txtPertencente.Text = equip.Pertencente;
                _txtPatrimonio.Text = equip.Patrimonio;

                pnTermo.BringToFront();
            }
        }

        private void cbDescricao_DropDown(object sender, EventArgs e)
        {
            CTRL_Equipamento cEquip = new CTRL_Equipamento();
            List<Equipamento> list = new List<Equipamento>();

            list = cEquip.GetAll();
            cbDescricao.DataSource = list;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Util.LimparCampos(pnTermo.Controls);
        }
    }
}
