namespace prjEstoque.View
{
    partial class frmRelatorio_Equipamento
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
            this.gbTermo = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtPertencente = new System.Windows.Forms.TextBox();
            this._txtCategoria = new System.Windows.Forms.TextBox();
            this._txtEstado = new System.Windows.Forms.TextBox();
            this._txtPatrimonio = new System.Windows.Forms.TextBox();
            this._txtNSerie = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar_Termo = new System.Windows.Forms.Button();
            this.btnCadastrar_Termo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTermo_Slider = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnCampos = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbTermo.SuspendLayout();
            this.pnCampos.SuspendLayout();
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
            this.pnTop.Size = new System.Drawing.Size(800, 38);
            this.pnTop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(721, 0);
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
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            // gbTermo
            // 
            this.gbTermo.Controls.Add(this.txtDescricao);
            this.gbTermo.Controls.Add(this.label16);
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
            this.gbTermo.Controls.Add(this.label11);
            this.gbTermo.Controls.Add(this.btnTermo_Slider);
            this.gbTermo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTermo.ForeColor = System.Drawing.Color.White;
            this.gbTermo.Location = new System.Drawing.Point(0, 125);
            this.gbTermo.Name = "gbTermo";
            this.gbTermo.Size = new System.Drawing.Size(800, 189);
            this.gbTermo.TabIndex = 2;
            this.gbTermo.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(473, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Patrimônio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(479, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Categoria:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(74, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Pertencente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nº de série:";
            // 
            // _txtPertencente
            // 
            this._txtPertencente.Enabled = false;
            this._txtPertencente.Location = new System.Drawing.Point(567, 87);
            this._txtPertencente.Name = "_txtPertencente";
            this._txtPertencente.Size = new System.Drawing.Size(206, 26);
            this._txtPertencente.TabIndex = 29;
            // 
            // _txtCategoria
            // 
            this._txtCategoria.Enabled = false;
            this._txtCategoria.Location = new System.Drawing.Point(567, 28);
            this._txtCategoria.Name = "_txtCategoria";
            this._txtCategoria.Size = new System.Drawing.Size(206, 26);
            this._txtCategoria.TabIndex = 28;
            // 
            // _txtEstado
            // 
            this._txtEstado.Enabled = false;
            this._txtEstado.Location = new System.Drawing.Point(144, 87);
            this._txtEstado.Name = "_txtEstado";
            this._txtEstado.Size = new System.Drawing.Size(206, 26);
            this._txtEstado.TabIndex = 27;
            // 
            // _txtPatrimonio
            // 
            this._txtPatrimonio.Enabled = false;
            this._txtPatrimonio.Location = new System.Drawing.Point(567, 146);
            this._txtPatrimonio.Name = "_txtPatrimonio";
            this._txtPatrimonio.Size = new System.Drawing.Size(206, 26);
            this._txtPatrimonio.TabIndex = 26;
            // 
            // _txtNSerie
            // 
            this._txtNSerie.Enabled = false;
            this._txtNSerie.Location = new System.Drawing.Point(144, 148);
            this._txtNSerie.Name = "_txtNSerie";
            this._txtNSerie.Size = new System.Drawing.Size(206, 26);
            this._txtNSerie.TabIndex = 25;
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtRg.Location = new System.Drawing.Point(567, 34);
            this.txtRg.Mask = "000,000,000-00";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(206, 26);
            this.txtRg.TabIndex = 24;
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.dtpRetirada.Location = new System.Drawing.Point(144, 35);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(206, 26);
            this.dtpRetirada.TabIndex = 23;
            // 
            // btnLimpar_Termo
            // 
            this.btnLimpar_Termo.BackColor = System.Drawing.Color.Red;
            this.btnLimpar_Termo.FlatAppearance.BorderSize = 0;
            this.btnLimpar_Termo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar_Termo.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar_Termo.Location = new System.Drawing.Point(802, 256);
            this.btnLimpar_Termo.Name = "btnLimpar_Termo";
            this.btnLimpar_Termo.Size = new System.Drawing.Size(33, 31);
            this.btnLimpar_Termo.TabIndex = 22;
            this.btnLimpar_Termo.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar_Termo
            // 
            this.btnCadastrar_Termo.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar_Termo.FlatAppearance.BorderSize = 0;
            this.btnCadastrar_Termo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar_Termo.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar_Termo.Location = new System.Drawing.Point(762, 320);
            this.btnCadastrar_Termo.Name = "btnCadastrar_Termo";
            this.btnCadastrar_Termo.Size = new System.Drawing.Size(33, 31);
            this.btnCadastrar_Termo.TabIndex = 21;
            this.btnCadastrar_Termo.UseVisualStyleBackColor = false;
            this.btnCadastrar_Termo.Click += new System.EventHandler(this.btnCadastrar_Termo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Equipamento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(523, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "RG:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Data de retirada:";
            // 
            // btnTermo_Slider
            // 
            this.btnTermo_Slider.FlatAppearance.BorderSize = 0;
            this.btnTermo_Slider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermo_Slider.Image = global::prjEstoque.Properties.Resources.icons8_chevron_esquerda_16;
            this.btnTermo_Slider.Location = new System.Drawing.Point(805, 10);
            this.btnTermo_Slider.Name = "btnTermo_Slider";
            this.btnTermo_Slider.Size = new System.Drawing.Size(30, 16);
            this.btnTermo_Slider.TabIndex = 8;
            this.btnTermo_Slider.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(144, 28);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(206, 26);
            this.txtDescricao.TabIndex = 35;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(721, 320);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(33, 31);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pnCampos
            // 
            this.pnCampos.Controls.Add(this.dtpRetirada);
            this.pnCampos.Controls.Add(this.txtRg);
            this.pnCampos.Controls.Add(this.label12);
            this.pnCampos.Controls.Add(this.label14);
            this.pnCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCampos.Location = new System.Drawing.Point(0, 38);
            this.pnCampos.Name = "pnCampos";
            this.pnCampos.Size = new System.Drawing.Size(800, 100);
            this.pnCampos.TabIndex = 26;
            // 
            // frmRelatorio_Equipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.pnCampos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbTermo);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.btnCadastrar_Termo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio_Equipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRelatorio_Equipamento";
            this.Load += new System.EventHandler(this.frmRelatorio_Equipamento_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbTermo.ResumeLayout(false);
            this.gbTermo.PerformLayout();
            this.pnCampos.ResumeLayout(false);
            this.pnCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbTermo;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTermo_Slider;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.Button btnCadastrar_Termo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel pnCampos;
    }
}