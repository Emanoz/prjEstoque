namespace prjEstoque.View
{
    partial class frmEditarBase
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnEquipamento = new System.Windows.Forms.Panel();
            this.btnLimpar_Equi = new System.Windows.Forms.Button();
            this.btnCadastrar_Equi = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPertencente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNSerie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnEquipamento.SuspendLayout();
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
            this.pnTop.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(717, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 38);
            this.panel1.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEstoque.Properties.Resources.icons8_caixa_39;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnEquipamento
            // 
            this.pnEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnEquipamento.Controls.Add(this.btnLimpar_Equi);
            this.pnEquipamento.Controls.Add(this.btnCadastrar_Equi);
            this.pnEquipamento.Controls.Add(this.cbCategoria);
            this.pnEquipamento.Controls.Add(this.txtPatrimonio);
            this.pnEquipamento.Controls.Add(this.label9);
            this.pnEquipamento.Controls.Add(this.txtPertencente);
            this.pnEquipamento.Controls.Add(this.label8);
            this.pnEquipamento.Controls.Add(this.label7);
            this.pnEquipamento.Controls.Add(this.txtEstado);
            this.pnEquipamento.Controls.Add(this.label6);
            this.pnEquipamento.Controls.Add(this.txtNSerie);
            this.pnEquipamento.Controls.Add(this.label5);
            this.pnEquipamento.Controls.Add(this.txtDescricao);
            this.pnEquipamento.Controls.Add(this.label4);
            this.pnEquipamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnEquipamento.Location = new System.Drawing.Point(0, 38);
            this.pnEquipamento.Name = "pnEquipamento";
            this.pnEquipamento.Size = new System.Drawing.Size(800, 302);
            this.pnEquipamento.TabIndex = 4;
            // 
            // btnLimpar_Equi
            // 
            this.btnLimpar_Equi.BackColor = System.Drawing.Color.Red;
            this.btnLimpar_Equi.FlatAppearance.BorderSize = 0;
            this.btnLimpar_Equi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar_Equi.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar_Equi.Location = new System.Drawing.Point(650, 259);
            this.btnLimpar_Equi.Name = "btnLimpar_Equi";
            this.btnLimpar_Equi.Size = new System.Drawing.Size(138, 31);
            this.btnLimpar_Equi.TabIndex = 36;
            this.btnLimpar_Equi.Text = "Limpar Campos";
            this.btnLimpar_Equi.UseVisualStyleBackColor = false;
            this.btnLimpar_Equi.Click += new System.EventHandler(this.btnLimpar_Equi_Click);
            // 
            // btnCadastrar_Equi
            // 
            this.btnCadastrar_Equi.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar_Equi.FlatAppearance.BorderSize = 0;
            this.btnCadastrar_Equi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar_Equi.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar_Equi.Location = new System.Drawing.Point(480, 259);
            this.btnCadastrar_Equi.Name = "btnCadastrar_Equi";
            this.btnCadastrar_Equi.Size = new System.Drawing.Size(138, 31);
            this.btnCadastrar_Equi.TabIndex = 35;
            this.btnCadastrar_Equi.Text = "OK";
            this.btnCadastrar_Equi.UseVisualStyleBackColor = false;
            this.btnCadastrar_Equi.Click += new System.EventHandler(this.btnCadastrar_Equi_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(136, 175);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(206, 28);
            this.cbCategoria.TabIndex = 34;
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.Location = new System.Drawing.Point(524, 175);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(206, 26);
            this.txtPatrimonio.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(430, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Patrimônio:";
            // 
            // txtPertencente
            // 
            this.txtPertencente.Location = new System.Drawing.Point(524, 106);
            this.txtPertencente.Name = "txtPertencente";
            this.txtPertencente.Size = new System.Drawing.Size(206, 26);
            this.txtPertencente.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(418, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Pertencente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Categoria:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(136, 103);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(206, 26);
            this.txtEstado.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Estado:";
            // 
            // txtNSerie
            // 
            this.txtNSerie.Location = new System.Drawing.Point(524, 36);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.Size = new System.Drawing.Size(206, 26);
            this.txtNSerie.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(428, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nº de série:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(136, 36);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(206, 26);
            this.txtDescricao.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Descrição:";
            // 
            // frmEditarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.pnEquipamento);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditarBase";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnEquipamento.ResumeLayout(false);
            this.pnEquipamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnEquipamento;
        private System.Windows.Forms.Button btnLimpar_Equi;
        private System.Windows.Forms.Button btnCadastrar_Equi;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPertencente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNSerie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
    }
}