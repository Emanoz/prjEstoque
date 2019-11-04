using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjEstoque.Controller;
using prjEstoque.Entity;
using prjEstoque.View;

namespace prjEstoque
{
    public partial class frmPrincipal : Form
    {
        private Util util = null;

        public frmPrincipal()
        {
            InitializeComponent();
            util = new Util();
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void BtnCreate_Click(object sender, EventArgs e) => pnCadastro.BringToFront();

        private void BtnList_Prod_Click(object sender, EventArgs e)
        {
            pnList_Equipamento.BringToFront();

        }

        private void btnRep_Arrow_Click(object sender, EventArgs e)
        {
            if(pnReport.Height == 54)
            {
                util.Slider(pnReport, 135, 251);
                btnRep_Arrow.Image = prjEstoque.Properties.Resources.icons8_triangle_arrow_14;
            }
            else
            {
                util.Slider(pnReport, 54, 251);
                btnRep_Arrow.Image = prjEstoque.Properties.Resources.icons8_chevron_right_16_1_;
            }
        }

        private void btnList_Arrow_Click(object sender, EventArgs e)
        {
            if (pnList.Height == 54)
            {
                util.Slider(pnList, 135, 251);
                btnList_Arrow.Image = prjEstoque.Properties.Resources.icons8_triangle_arrow_14;
            }
            else
            {
                util.Slider(pnList, 54, 251);
                btnList_Arrow.Image = prjEstoque.Properties.Resources.icons8_chevron_right_16_1_;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnCategoria_Slider_Click(object sender, EventArgs e)
        {
            util.Slider(pnGb_Categoria, gbCategoria, btnCategoria_Slider, 297, 832);
            opAtualizar_Click(null, null);
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(pnLeft.Width == 251)
            {
                util.Slider(pnLeft, 662, 59);
                btnCategoria_Slider.Location = new Point(997, btnCategoria_Slider.Location.Y);
            }
            else
            {
                util.Slider(pnLeft, 662, 251);
                btnCategoria_Slider.Location = new Point(805, btnCategoria_Slider.Location.Y);
            }
        }

        private void opAtualizar_Click(object sender, EventArgs e)
        {
            CTRL_Categoria cCat = new CTRL_Categoria();
            
            dgvCategoria.DataSource = cCat.GetAll();
            FormatarDgv.FormatarCategoria(dgvCategoria);
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CTRL_Categoria cCat = new CTRL_Categoria();
            Categoria c = new Categoria(txtCategoria.Text);

            if(cCat.Insert(c) == 0)
                MessageBox.Show("O registro não foi cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            opAtualizar_Click(null, null);
        }

        private void opAtualizar_Campo_Click(object sender, EventArgs e)
        {
            CTRL_Categoria cCat = new CTRL_Categoria();
            Categoria c = new Categoria(int.Parse(dgvCategoria[0, dgvCategoria.CurrentRow.Index].Value.ToString()), txtCategoria.Text);

            if (cCat.Update(c) == 0)
                MessageBox.Show("O registro não foi atualizado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            opAtualizar_Click(null, null);
        }

        private void opDeletar_Campo_Click(object sender, EventArgs e)
        {
            CTRL_Categoria cCat = new CTRL_Categoria();

            if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (cCat.Delete(int.Parse(dgvCategoria[0, dgvCategoria.CurrentRow.Index].Value.ToString())) == 0)
                    MessageBox.Show("O registro não foi excluído!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                opAtualizar_Click(null, null);
            }
        }

        private void cbCategoria_DropDown(object sender, EventArgs e)
        {
            CTRL_Categoria cCat = new CTRL_Categoria();

            cbCategoria.DataSource = cCat.GetAll();
        }

        private void btnEquipamento_Slider_Click(object sender, EventArgs e) => util.Slider(pnGb_Equipamento, gbEquipamento, btnEquipamento_Slider, 238, 849);

        private void btnCadastrar_Equi_Click(object sender, EventArgs e)
        {
            CTRL_Equipamento eEqui = new CTRL_Equipamento();
            CTRL_Categoria cCat = new CTRL_Categoria();
            List<Categoria> list = cCat.GetAll();
            int index = 0;

            foreach(Categoria c in list)
            {
                if (c.Descricao == cbCategoria.Text)
                    index = c.CodCategoria;
            }
            Equipamento equi = new Equipamento(txtDescricao.Text, txtNSerie.Text, txtEstado.Text, index, txtPertencente.Text, txtPatrimonio.Text);

            if (eEqui.Insert(equi) == 0)
                MessageBox.Show("O registro não foi cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpar_Equi_Click(object sender, EventArgs e)
        {
            Util.LimparCampos(gbEquipamento.Controls);
        }

        private void btnLimpar_Cat_Click(object sender, EventArgs e)
        {
            Util.LimparCampos(gbCategoria.Controls);
        }

        private void btnLimpar_Est_Click(object sender, EventArgs e)
        {
            Util.LimparCampos(gbEstoque.Controls);
        }

        private void opRefresh_Est_Click(object sender, EventArgs e)
        {
            CTRL_Estoque cEst = new CTRL_Estoque();

            dgvEstoque.DataSource = cEst.GetAll();
            FormatarDgv.FormatarEstoque(dgvEstoque);
        }

        private void btnEstoque_Slider_Click(object sender, EventArgs e)
        {
            util.Slider(pnGb_Estoque, gbEstoque, btnEstoque_Slider, 297, 832);
            opRefresh_Est_Click(null, null);
        }

        private void btnCadastrar_Est_Click(object sender, EventArgs e)
        {
            CTRL_Estoque cEst = new CTRL_Estoque();
            Estoque est = new Estoque(txtEstoque.Text);

            if(cEst.Insert(est) == 0)
                MessageBox.Show("O registro não foi cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            opRefresh_Est_Click(null, null);
        }

        private void opAtualizar_Est_Click(object sender, EventArgs e)
        {
            CTRL_Estoque cEst = new CTRL_Estoque();
            Estoque est = new Estoque(int.Parse(dgvEstoque[0, dgvEstoque.CurrentRow.Index].Value.ToString()), txtEstoque.Text);

            if(cEst.Update(est) == 0)
                MessageBox.Show("O registro não foi atualizado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            opRefresh_Est_Click(null, null);
        }

        private void opExcluir_Est_Click(object sender, EventArgs e)
        {
            CTRL_Estoque cEst = new CTRL_Estoque();
            
            if(MessageBox.Show("Tem certeza que deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (cEst.Delete(int.Parse(dgvEstoque[0, dgvEstoque.CurrentRow.Index].Value.ToString())) == 0)
                    MessageBox.Show("O registro não foi excluído!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                opRefresh_Est_Click(null, null);
            }
        }

        private void btnList_Equip_Click(object sender, EventArgs e)
        {
            CTRL_Equipamento cEquip = new CTRL_Equipamento();

            pnList_Equipamento.BringToFront();
            dgvEquipamento.DataSource = cEquip.GetAll();
            FormatarDgv.FormatarEquipamento(dgvEquipamento);
        }

        private void opRefresh_Equip_Click(object sender, EventArgs e)
        {
            CTRL_Equipamento cEquip = new CTRL_Equipamento();

            dgvEquipamento.DataSource = cEquip.GetAll();
            FormatarDgv.FormatarEquipamento(dgvEquipamento);
        }

        private void opAtualizar_Equip_Click(object sender, EventArgs e)
        {
            CTRL_Equipamento cEquip = new CTRL_Equipamento();
            Equipamento equip = new Equipamento(int.Parse(dgvEquipamento[0, dgvEquipamento.CurrentRow.Index].Value.ToString()),
                                                dgvEquipamento[1, dgvEquipamento.CurrentRow.Index].Value.ToString(),
                                                dgvEquipamento[2, dgvEquipamento.CurrentRow.Index].Value.ToString(),
                                                dgvEquipamento[3, dgvEquipamento.CurrentRow.Index].Value.ToString(),
                                                int.Parse(dgvEquipamento[4, dgvEquipamento.CurrentRow.Index].Value.ToString()),
                                                dgvEquipamento[5, dgvEquipamento.CurrentRow.Index].Value.ToString(),
                                                dgvEquipamento[6, dgvEquipamento.CurrentRow.Index].Value.ToString());
            using(var editar = new frmEditarBase(equip))
                editar.ShowDialog();
            opRefresh_Equip_Click(null, null);
        }

        private void opExcluir_Equip_Click(object sender, EventArgs e)
        {
            CTRL_Equipamento cEquip = new CTRL_Equipamento();

            if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (cEquip.Delete(int.Parse(dgvEquipamento[0, dgvEquipamento.CurrentRow.Index].Value.ToString())) == 0)
                    MessageBox.Show("O registro não foi excluído!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                opRefresh_Equip_Click(null, null);
            }
        }

        private void opRelatorio_Equip_Click(object sender, EventArgs e)
        {
            using (var r = new frmRelatorio_Equipamento(int.Parse(dgvEquipamento[0, dgvEquipamento.CurrentRow.Index].Value.ToString())))
                r.ShowDialog();

        }

        private void btnList_Termo_Click(object sender, EventArgs e)
        {
            pnList_Termo.BringToFront();
            opRefresh_Termo_Click(null, null);

        }

        private void opRefresh_Termo_Click(object sender, EventArgs e)
        {
            CTRL_Termo_Emprestimo cTermo = new CTRL_Termo_Emprestimo();

            dgvTermo.DataSource = cTermo.GetAll();
            FormatarDgv.FormatarTermo(dgvTermo);
        }
    }
}
