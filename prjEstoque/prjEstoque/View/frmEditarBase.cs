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
        private int index, _indexCat;
        public object Entity { get; set; }
        public List<Equipamento> ListEquipamento { get; set; }
        public List<Categoria> ListCategoria { get; set; }
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
                if (cEquip.Update(new Equipamento(index, txtDescricao.Text, txtNSerie.Text, txtEstado.Text, _indexCat,
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
                dtpDevolucao.Value = ((Termo_Emprestimo)Entity).DataDevolucao;

                CTRL_Equipamento cEquip = new CTRL_Equipamento();
                Equipamento equip = new Equipamento();

                equip = cEquip.GetById(((Termo_Emprestimo)Entity).CodEquipamento);
                _indexCat = equip.CodCategoria;
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
            ListEquipamento = new List<Equipamento>();

            ListEquipamento = cEquip.GetAll();
            cbDescricao.DataSource = ListEquipamento;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Util.LimparCampos(pnTermo.Controls);
        }

        private void cbDevolvido_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDevolvido.Checked)
                dtpDevolucao.Enabled = true;
            else
                dtpDevolucao.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CTRL_Termo_Emprestimo cTermo = new CTRL_Termo_Emprestimo();
            Termo_Emprestimo termo = null;
            if (cbDevolvido.Checked)
            {
                termo = new Termo_Emprestimo(((Termo_Emprestimo)Entity).CodTermo, dtpRetirada.Value, txtRg.Text,
                                                            dtpDevolucao.Value, _indexCat);
            }
            else
            {
                termo = new Termo_Emprestimo(((Termo_Emprestimo)Entity).CodTermo, dtpRetirada.Value, txtRg.Text, DateTime.Today, _indexCat);
            }


            if (cTermo.Update(termo) <= 0)
                MessageBox.Show("O registro não foi atualizado com sucesso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();
        }

        private void cbCategoria_DropDown(object sender, EventArgs e)
        {
            CTRL_Categoria cCat = new CTRL_Categoria();
            ListCategoria = new List<Categoria>();

            ListCategoria = cCat.GetAll();
            cbCategoria.DataSource = ListCategoria;
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            _indexCat = ListCategoria[cbCategoria.SelectedIndex].CodCategoria;
        }

        private void cbDescricao_SelectedValueChanged(object sender, EventArgs e)
        {
            _indexCat = ListEquipamento[cbDescricao.SelectedIndex].CodCategoria;
            _txtEstado.Text = ListEquipamento[cbDescricao.SelectedIndex].Estado;
            _txtNSerie.Text = ListEquipamento[cbDescricao.SelectedIndex].NumSerie;
            _txtCategoria.Text = ListEquipamento[cbDescricao.SelectedIndex].CodCategoria.ToString();
            _txtPertencente.Text = ListEquipamento[cbDescricao.SelectedIndex].Pertencente;
            _txtPatrimonio.Text = ListEquipamento[cbDescricao.SelectedIndex].Patrimonio;
        }
    }
}
