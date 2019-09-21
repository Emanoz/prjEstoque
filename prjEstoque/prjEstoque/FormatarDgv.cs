using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque
{
    static class FormatarDgv
    {
        public static void FormatarCategoria(System.Windows.Forms.DataGridView dgv)
        {
            dgv.Columns["CodCategoria"].Visible = false;
            dgv.Columns["Descricao"].HeaderText = "Descrição";
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.Columns["Descricao"].Width = 190;
        }
    }
}
