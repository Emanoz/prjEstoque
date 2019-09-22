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

        private void BtnList_Prod_Click(object sender, EventArgs e) => pnList_Prod.BringToFront();

        private void BtnList_Forn_Click(object sender, EventArgs e) => pnList_Forn.BringToFront();

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
            else
                MessageBox.Show("O registro foi cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            opAtualizar_Click(null, null);
        }

        private void opAtualizar_Campo_Click(object sender, EventArgs e)
        {
            CTRL_Categoria cCat = new CTRL_Categoria();
            Categoria c = new Categoria(int.Parse(dgvCategoria[0, dgvCategoria.CurrentRow.Index].Value.ToString()), txtCategoria.Text);

            if (cCat.Update(c) == 0)
                MessageBox.Show("O registro não foi atualizado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("O registro foi atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            opAtualizar_Click(null, null);
        }

        private void opDeletar_Campo_Click(object sender, EventArgs e)
        {
            CTRL_Categoria cCat = new CTRL_Categoria();
;
            if(cCat.Delete(int.Parse(dgvCategoria[0, dgvCategoria.CurrentRow.Index].Value.ToString())) == 0)
                MessageBox.Show("O registro não foi excluído!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("O registro foi excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            opAtualizar_Click(null, null);
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
            else
                MessageBox.Show("O registro foi cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpar_Equi_Click(object sender, EventArgs e)
        {

        }
    }
}
