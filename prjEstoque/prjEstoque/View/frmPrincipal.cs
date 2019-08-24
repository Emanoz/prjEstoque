using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEstoque
{
    public partial class frmDashboard : Form
    {
        private Util util = null;

        public frmDashboard()
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

        private void btnProd_Slider_Click(object sender, EventArgs e)
        {
            if (txtProd_Nome.Height == 28)
            {
                util.Slider(txtProd_Nome, 250, 849);
                util.Slider(pnGb_Prod, 315, 849);
                btnProd_Slider.Image = prjEstoque.Properties.Resources.icons8_triangle_arrow_14;
            }
            else
            {
                util.Slider(txtProd_Nome, 28, 849);
                util.Slider(pnGb_Prod, 65, 849);
                btnProd_Slider.Image = prjEstoque.Properties.Resources.icons8_chevron_esquerda_16;
            }
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(pnLeft.Width == 251)
            {
                util.Slider(pnLeft, 662, 59);
                btnProd_Slider.Location = new Point(997, btnProd_Slider.Location.Y);
            }
            else
            {
                util.Slider(pnLeft, 662, 251);
                btnProd_Slider.Location = new Point(805, btnProd_Slider.Location.Y);
            }
        }
    }
}
