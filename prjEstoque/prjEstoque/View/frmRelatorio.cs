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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio(TermoEquipamento t)
        {
            InitializeComponent();
            this.rptReport.LocalReport.ReportPath = @"C:\Users\monitor\Desktop\Emanos\prjEstoque\prjEstoque\prjEstoque\Report\rptTermo.rdlc";
            this.rptReport.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("txtRg", t.Rg));
            this.rptReport.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("txtDataRetirada", t.DtpRetirada.ToString()));
            this.rptReport.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("txtDescricao", t.Descricao));
            this.rptReport.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("txtPatrimonio", t.Patrimonio));
            this.rptReport.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("txtNSerie", t.NSerie));
            this.rptReport.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("txtDataDevolucao", t.DtpDevolucao.ToString()));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {

            this.rptReport.RefreshReport();
        }
    }
}
