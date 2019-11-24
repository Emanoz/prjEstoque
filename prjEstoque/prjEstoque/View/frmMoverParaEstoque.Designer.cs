namespace prjEstoque.View
{
    partial class frmMoverParaEstoque
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.gbTermo = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtPertencente = new System.Windows.Forms.TextBox();
            this._txtCategoria = new System.Windows.Forms.TextBox();
            this._txtEstado = new System.Windows.Forms.TextBox();
            this._txtPatrimonio = new System.Windows.Forms.TextBox();
            this._txtNSerie = new System.Windows.Forms.TextBox();
            this.btnLimpar_Termo = new System.Windows.Forms.Button();
            this.btnTermo_Slider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstoque = new System.Windows.Forms.ComboBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnCadastro.SuspendLayout();
            this.gbTermo.SuspendLayout();
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
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(906, 47);
            this.pnTop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(801, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 47);
            this.panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(67, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Gerenciador de Estoque 3000";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::prjEstoque.Properties.Resources.icons8_excluir_42;
            this.btnClose.Location = new System.Drawing.Point(55, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 47);
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
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(51, 47);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEstoque.Properties.Resources.icons8_caixa_39;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnCadastro
            // 
            this.pnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnCadastro.Controls.Add(this.gbTermo);
            this.pnCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.pnCadastro.Location = new System.Drawing.Point(0, 47);
            this.pnCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(906, 314);
            this.pnCadastro.TabIndex = 4;
            // 
            // gbTermo
            // 
            this.gbTermo.Controls.Add(this.txtDescricao);
            this.gbTermo.Controls.Add(this.btnMover);
            this.gbTermo.Controls.Add(this.label3);
            this.gbTermo.Controls.Add(this.cbEstoque);
            this.gbTermo.Controls.Add(this.label16);
            this.gbTermo.Controls.Add(this.label10);
            this.gbTermo.Controls.Add(this.label15);
            this.gbTermo.Controls.Add(this.label13);
            this.gbTermo.Controls.Add(this.label2);
            this.gbTermo.Controls.Add(this.label1);
            this.gbTermo.Controls.Add(this._txtPertencente);
            this.gbTermo.Controls.Add(this._txtCategoria);
            this.gbTermo.Controls.Add(this._txtEstado);
            this.gbTermo.Controls.Add(this._txtPatrimonio);
            this.gbTermo.Controls.Add(this._txtNSerie);
            this.gbTermo.Controls.Add(this.btnLimpar_Termo);
            this.gbTermo.Controls.Add(this.btnTermo_Slider);
            this.gbTermo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTermo.ForeColor = System.Drawing.Color.White;
            this.gbTermo.Location = new System.Drawing.Point(4, 4);
            this.gbTermo.Margin = new System.Windows.Forms.Padding(4);
            this.gbTermo.Name = "gbTermo";
            this.gbTermo.Padding = new System.Windows.Forms.Padding(4);
            this.gbTermo.Size = new System.Drawing.Size(897, 304);
            this.gbTermo.TabIndex = 38;
            this.gbTermo.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(475, 182);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 25);
            this.label16.TabIndex = 34;
            this.label16.Text = "Patrimônio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "Descrição:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(483, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "Categoria:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Pertencente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nº de série:";
            // 
            // _txtPertencente
            // 
            this._txtPertencente.Enabled = false;
            this._txtPertencente.Location = new System.Drawing.Point(601, 106);
            this._txtPertencente.Margin = new System.Windows.Forms.Padding(4);
            this._txtPertencente.Name = "_txtPertencente";
            this._txtPertencente.Size = new System.Drawing.Size(273, 30);
            this._txtPertencente.TabIndex = 29;
            // 
            // _txtCategoria
            // 
            this._txtCategoria.Enabled = false;
            this._txtCategoria.Location = new System.Drawing.Point(601, 33);
            this._txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this._txtCategoria.Name = "_txtCategoria";
            this._txtCategoria.Size = new System.Drawing.Size(273, 30);
            this._txtCategoria.TabIndex = 28;
            // 
            // _txtEstado
            // 
            this._txtEstado.Enabled = false;
            this._txtEstado.Location = new System.Drawing.Point(146, 107);
            this._txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this._txtEstado.Name = "_txtEstado";
            this._txtEstado.Size = new System.Drawing.Size(273, 30);
            this._txtEstado.TabIndex = 27;
            // 
            // _txtPatrimonio
            // 
            this._txtPatrimonio.Enabled = false;
            this._txtPatrimonio.Location = new System.Drawing.Point(601, 179);
            this._txtPatrimonio.Margin = new System.Windows.Forms.Padding(4);
            this._txtPatrimonio.Name = "_txtPatrimonio";
            this._txtPatrimonio.Size = new System.Drawing.Size(273, 30);
            this._txtPatrimonio.TabIndex = 26;
            // 
            // _txtNSerie
            // 
            this._txtNSerie.Enabled = false;
            this._txtNSerie.Location = new System.Drawing.Point(146, 182);
            this._txtNSerie.Margin = new System.Windows.Forms.Padding(4);
            this._txtNSerie.Name = "_txtNSerie";
            this._txtNSerie.Size = new System.Drawing.Size(273, 30);
            this._txtNSerie.TabIndex = 25;
            // 
            // btnLimpar_Termo
            // 
            this.btnLimpar_Termo.BackColor = System.Drawing.Color.Red;
            this.btnLimpar_Termo.FlatAppearance.BorderSize = 0;
            this.btnLimpar_Termo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar_Termo.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar_Termo.Location = new System.Drawing.Point(1069, 315);
            this.btnLimpar_Termo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar_Termo.Name = "btnLimpar_Termo";
            this.btnLimpar_Termo.Size = new System.Drawing.Size(44, 38);
            this.btnLimpar_Termo.TabIndex = 22;
            this.btnLimpar_Termo.UseVisualStyleBackColor = false;
            // 
            // btnTermo_Slider
            // 
            this.btnTermo_Slider.FlatAppearance.BorderSize = 0;
            this.btnTermo_Slider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermo_Slider.Image = global::prjEstoque.Properties.Resources.icons8_chevron_esquerda_16;
            this.btnTermo_Slider.Location = new System.Drawing.Point(1073, 12);
            this.btnTermo_Slider.Margin = new System.Windows.Forms.Padding(4);
            this.btnTermo_Slider.Name = "btnTermo_Slider";
            this.btnTermo_Slider.Size = new System.Drawing.Size(40, 20);
            this.btnTermo_Slider.TabIndex = 8;
            this.btnTermo_Slider.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mover para:";
            // 
            // cbEstoque
            // 
            this.cbEstoque.FormattingEnabled = true;
            this.cbEstoque.Location = new System.Drawing.Point(146, 252);
            this.cbEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstoque.Name = "cbEstoque";
            this.cbEstoque.Size = new System.Drawing.Size(273, 33);
            this.cbEstoque.TabIndex = 46;
            this.cbEstoque.DropDown += new System.EventHandler(this.cbEstoque_DropDown);
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMover.FlatAppearance.BorderSize = 0;
            this.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMover.ForeColor = System.Drawing.Color.Black;
            this.btnMover.Location = new System.Drawing.Point(480, 252);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(128, 33);
            this.btnMover.TabIndex = 48;
            this.btnMover.Text = "MOVER";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(146, 39);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(273, 30);
            this.txtDescricao.TabIndex = 49;
            // 
            // frmMoverParaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 361);
            this.Controls.Add(this.pnCadastro);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMoverParaEstoque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMoverParaEstoque";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnCadastro.ResumeLayout(false);
            this.gbTermo.ResumeLayout(false);
            this.gbTermo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnCadastro;
        private System.Windows.Forms.GroupBox gbTermo;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstoque;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtPertencente;
        private System.Windows.Forms.TextBox _txtCategoria;
        private System.Windows.Forms.TextBox _txtEstado;
        private System.Windows.Forms.TextBox _txtPatrimonio;
        private System.Windows.Forms.TextBox _txtNSerie;
        private System.Windows.Forms.Button btnLimpar_Termo;
        private System.Windows.Forms.Button btnTermo_Slider;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}