namespace prjEstoque
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnList = new System.Windows.Forms.Panel();
            this.btnList_Forn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnReport = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRep_prod = new System.Windows.Forms.Button();
            this.btnRep_Forn = new System.Windows.Forms.Button();
            this.btnList_Prod = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbProduto = new System.Windows.Forms.Panel();
            this.pnGroup_Op = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnGb_Prod = new System.Windows.Forms.Panel();
            this.pnGb_Forn = new System.Windows.Forms.Panel();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.pnGb_Cat = new System.Windows.Forms.Panel();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.pnList_Prod = new System.Windows.Forms.Panel();
            this.pnList_Forn = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnList.SuspendLayout();
            this.pnReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbProduto.SuspendLayout();
            this.pnGroup_Op.SuspendLayout();
            this.pnGb_Prod.SuspendLayout();
            this.pnGb_Forn.SuspendLayout();
            this.pnGb_Cat.SuspendLayout();
            this.pnList_Forn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Controls.Add(this.lblTitle);
            this.pnTop.Controls.Add(this.pictureBox1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1100, 38);
            this.pnTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1021, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 38);
            this.panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Gerenciador de Estoque 3000";
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnLeft.Controls.Add(this.pnList);
            this.pnLeft.Controls.Add(this.pnReport);
            this.pnLeft.Controls.Add(this.btnCreate);
            this.pnLeft.Controls.Add(this.btnSlide);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 38);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(251, 662);
            this.pnLeft.TabIndex = 1;
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(251, 38);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(849, 662);
            this.pnHome.TabIndex = 2;
            // 
            // btnSlide
            // 
            this.btnSlide.FlatAppearance.BorderSize = 0;
            this.btnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide.Location = new System.Drawing.Point(95, 22);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(67, 57);
            this.btnSlide.TabIndex = 0;
            this.btnSlide.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 119);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(251, 65);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Cadastro";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.label1);
            this.pnList.Controls.Add(this.btnList_Prod);
            this.pnList.Controls.Add(this.btnList_Forn);
            this.pnList.Location = new System.Drawing.Point(0, 190);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(251, 126);
            this.pnList.TabIndex = 0;
            // 
            // btnList_Forn
            // 
            this.btnList_Forn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnList_Forn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList_Forn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnList_Forn.FlatAppearance.BorderSize = 0;
            this.btnList_Forn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList_Forn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList_Forn.ForeColor = System.Drawing.Color.White;
            this.btnList_Forn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList_Forn.Location = new System.Drawing.Point(0, 90);
            this.btnList_Forn.Name = "btnList_Forn";
            this.btnList_Forn.Size = new System.Drawing.Size(251, 36);
            this.btnList_Forn.TabIndex = 3;
            this.btnList_Forn.Text = "Fornecedor";
            this.btnList_Forn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listagem";
            // 
            // pnReport
            // 
            this.pnReport.Controls.Add(this.label2);
            this.pnReport.Controls.Add(this.btnRep_prod);
            this.pnReport.Controls.Add(this.btnRep_Forn);
            this.pnReport.Location = new System.Drawing.Point(0, 322);
            this.pnReport.Name = "pnReport";
            this.pnReport.Size = new System.Drawing.Size(251, 126);
            this.pnReport.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Relatório";
            // 
            // btnRep_prod
            // 
            this.btnRep_prod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRep_prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRep_prod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRep_prod.FlatAppearance.BorderSize = 0;
            this.btnRep_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRep_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRep_prod.ForeColor = System.Drawing.Color.White;
            this.btnRep_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRep_prod.Location = new System.Drawing.Point(0, 54);
            this.btnRep_prod.Name = "btnRep_prod";
            this.btnRep_prod.Size = new System.Drawing.Size(251, 36);
            this.btnRep_prod.TabIndex = 4;
            this.btnRep_prod.Text = "Produtos";
            this.btnRep_prod.UseVisualStyleBackColor = true;
            // 
            // btnRep_Forn
            // 
            this.btnRep_Forn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRep_Forn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRep_Forn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRep_Forn.FlatAppearance.BorderSize = 0;
            this.btnRep_Forn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRep_Forn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRep_Forn.ForeColor = System.Drawing.Color.White;
            this.btnRep_Forn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRep_Forn.Location = new System.Drawing.Point(0, 90);
            this.btnRep_Forn.Name = "btnRep_Forn";
            this.btnRep_Forn.Size = new System.Drawing.Size(251, 36);
            this.btnRep_Forn.TabIndex = 3;
            this.btnRep_Forn.Text = "Fornecedor";
            this.btnRep_Forn.UseVisualStyleBackColor = true;
            // 
            // btnList_Prod
            // 
            this.btnList_Prod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnList_Prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList_Prod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnList_Prod.FlatAppearance.BorderSize = 0;
            this.btnList_Prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList_Prod.ForeColor = System.Drawing.Color.White;
            this.btnList_Prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList_Prod.Location = new System.Drawing.Point(0, 54);
            this.btnList_Prod.Name = "btnList_Prod";
            this.btnList_Prod.Size = new System.Drawing.Size(251, 36);
            this.btnList_Prod.TabIndex = 4;
            this.btnList_Prod.Text = "Produtos";
            this.btnList_Prod.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::prjEstoque.Properties.Resources.icons8_excluir_42;
            this.btnClose.Location = new System.Drawing.Point(41, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::prjEstoque.Properties.Resources.icons8_minimizar_janela_38;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 38);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEstoque.Properties.Resources.icons8_caixa_39;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gbProduto
            // 
            this.gbProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.gbProduto.Controls.Add(this.pnGroup_Op);
            this.gbProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProduto.Location = new System.Drawing.Point(251, 38);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(849, 662);
            this.gbProduto.TabIndex = 3;
            // 
            // pnGroup_Op
            // 
            this.pnGroup_Op.AutoScroll = true;
            this.pnGroup_Op.Controls.Add(this.pnGb_Cat);
            this.pnGroup_Op.Controls.Add(this.pnGb_Forn);
            this.pnGroup_Op.Controls.Add(this.pnGb_Prod);
            this.pnGroup_Op.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnGroup_Op.Location = new System.Drawing.Point(0, 48);
            this.pnGroup_Op.Name = "pnGroup_Op";
            this.pnGroup_Op.Size = new System.Drawing.Size(849, 614);
            this.pnGroup_Op.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 23);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto:";
            // 
            // pnGb_Prod
            // 
            this.pnGb_Prod.Controls.Add(this.groupBox1);
            this.pnGb_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGb_Prod.Location = new System.Drawing.Point(0, 0);
            this.pnGb_Prod.Name = "pnGb_Prod";
            this.pnGb_Prod.Size = new System.Drawing.Size(849, 65);
            this.pnGb_Prod.TabIndex = 1;
            // 
            // pnGb_Forn
            // 
            this.pnGb_Forn.Controls.Add(this.gbFornecedor);
            this.pnGb_Forn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGb_Forn.Location = new System.Drawing.Point(0, 65);
            this.pnGb_Forn.Name = "pnGb_Forn";
            this.pnGb_Forn.Size = new System.Drawing.Size(849, 65);
            this.pnGb_Forn.TabIndex = 2;
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFornecedor.ForeColor = System.Drawing.Color.White;
            this.gbFornecedor.Location = new System.Drawing.Point(0, 0);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Size = new System.Drawing.Size(849, 23);
            this.gbFornecedor.TabIndex = 0;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Fornecedor:";
            // 
            // pnGb_Cat
            // 
            this.pnGb_Cat.Controls.Add(this.gbCategoria);
            this.pnGb_Cat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGb_Cat.Location = new System.Drawing.Point(0, 130);
            this.pnGb_Cat.Name = "pnGb_Cat";
            this.pnGb_Cat.Size = new System.Drawing.Size(849, 65);
            this.pnGb_Cat.TabIndex = 3;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.ForeColor = System.Drawing.Color.White;
            this.gbCategoria.Location = new System.Drawing.Point(0, 0);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(849, 23);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // pnList_Prod
            // 
            this.pnList_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnList_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList_Prod.Location = new System.Drawing.Point(251, 38);
            this.pnList_Prod.Name = "pnList_Prod";
            this.pnList_Prod.Size = new System.Drawing.Size(849, 662);
            this.pnList_Prod.TabIndex = 3;
            // 
            // pnList_Forn
            // 
            this.pnList_Forn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnList_Forn.Controls.Add(this.dgv);
            this.pnList_Forn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList_Forn.Location = new System.Drawing.Point(251, 38);
            this.pnList_Forn.Name = "pnList_Forn";
            this.pnList_Forn.Size = new System.Drawing.Size(849, 662);
            this.pnList_Forn.TabIndex = 4;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(849, 662);
            this.dgv.TabIndex = 0;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnList_Forn);
            this.Controls.Add(this.pnList_Prod);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnList.ResumeLayout(false);
            this.pnList.PerformLayout();
            this.pnReport.ResumeLayout(false);
            this.pnReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbProduto.ResumeLayout(false);
            this.pnGroup_Op.ResumeLayout(false);
            this.pnGb_Prod.ResumeLayout(false);
            this.pnGb_Forn.ResumeLayout(false);
            this.pnGb_Cat.ResumeLayout(false);
            this.pnList_Forn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList_Prod;
        private System.Windows.Forms.Button btnList_Forn;
        private System.Windows.Forms.Panel pnReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRep_prod;
        private System.Windows.Forms.Button btnRep_Forn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSlide;
        private System.Windows.Forms.Panel gbProduto;
        private System.Windows.Forms.Panel pnGroup_Op;
        private System.Windows.Forms.Panel pnGb_Cat;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Panel pnGb_Forn;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.Panel pnGb_Prod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnList_Prod;
        private System.Windows.Forms.Panel pnList_Forn;
        private System.Windows.Forms.DataGridView dgv;
    }
}

