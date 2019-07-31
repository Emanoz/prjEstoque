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
    }
}
