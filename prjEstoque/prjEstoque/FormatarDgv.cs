﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque
{
    class FormatarDgv
    {
        public static void FormatarCategoria(System.Windows.Forms.DataGridView dgv)
        {
            dgv.Columns["CodCategoria"].Visible = false;
            dgv.Columns["Descricao"].HeaderText = "Descrição";
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.Columns["Descricao"].Width = 200;
        }

        public static void FormatarEstoque(System.Windows.Forms.DataGridView dgv)
        {
            dgv.Columns["CodEstoque"].Visible = false;
            dgv.Columns["Local"].Width = 200;
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        public static void FormatarEquipamento(System.Windows.Forms.DataGridView dgv)
        {
            dgv.Columns["CodEquipamento"].HeaderText = "Código";
            dgv.Columns["CodEquipamento"].Width = 50;
            dgv.Columns["Descricao"].HeaderText = "Descrição";
            dgv.Columns["Descricao"].Width = 180;
            dgv.Columns["NumSerie"].HeaderText = "Nº de série";
            dgv.Columns["CodCategoria"].HeaderText = "Categoria";
            dgv.Columns["CodCategoria"].Width = 180;
            dgv.Columns["Patrimonio"].HeaderText = "Patrimônio";
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }
    }
}
