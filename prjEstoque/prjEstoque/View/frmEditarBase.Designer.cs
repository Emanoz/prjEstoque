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
            this.pnTermo = new System.Windows.Forms.Panel();
            this.cbDevolvido = new System.Windows.Forms.CheckBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTermo = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbDescricao = new System.Windows.Forms.ComboBox();
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
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnEquipamento.SuspendLayout();
            this.pnTermo.SuspendLayout();
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
            this.pnEquipamento.Size = new System.Drawing.Size(800, 359);
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
            // pnTermo
            // 
            this.pnTermo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnTermo.Controls.Add(this.cbDevolvido);
            this.pnTermo.Controls.Add(this.txtRg);
            this.pnTermo.Controls.Add(this.dtpDevolucao);
            this.pnTermo.Controls.Add(this.label3);
            this.pnTermo.Controls.Add(this.gbTermo);
            this.pnTermo.Controls.Add(this.dtpRetirada);
            this.pnTermo.Controls.Add(this.label12);
            this.pnTermo.Controls.Add(this.label14);
            this.pnTermo.Controls.Add(this.btnLimpar);
            this.pnTermo.Controls.Add(this.btnCadastrar);
            this.pnTermo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTermo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTermo.Location = new System.Drawing.Point(0, 38);
            this.pnTermo.Name = "pnTermo";
            this.pnTermo.Size = new System.Drawing.Size(800, 359);
            this.pnTermo.TabIndex = 5;
            // 
            // cbDevolvido
            // 
            this.cbDevolvido.AutoSize = true;
            this.cbDevolvido.ForeColor = System.Drawing.Color.White;
            this.cbDevolvido.Location = new System.Drawing.Point(372, 19);
            this.cbDevolvido.Name = "cbDevolvido";
            this.cbDevolvido.Size = new System.Drawing.Size(128, 24);
            this.cbDevolvido.TabIndex = 47;
            this.cbDevolvido.Text = "Foi devolvido?";
            this.cbDevolvido.UseVisualStyleBackColor = true;
            this.cbDevolvido.CheckedChanged += new System.EventHandler(this.cbDevolvido_CheckedChanged);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(149, 79);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(206, 26);
            this.txtRg.TabIndex = 46;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Enabled = false;
            this.dtpDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.dtpDevolucao.Location = new System.Drawing.Point(149, 19);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(206, 26);
            this.dtpDevolucao.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Data de devolução:";
            // 
            // gbTermo
            // 
            this.gbTermo.Controls.Add(this.label16);
            this.gbTermo.Controls.Add(this.label10);
            this.gbTermo.Controls.Add(this.label15);
            this.gbTermo.Controls.Add(this.cbDescricao);
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
            this.gbTermo.Location = new System.Drawing.Point(0, 109);
            this.gbTermo.Name = "gbTermo";
            this.gbTermo.Size = new System.Drawing.Size(800, 189);
            this.gbTermo.TabIndex = 37;
            this.gbTermo.TabStop = false;
            this.gbTermo.Text = "Equipamento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(478, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Patrimônio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(59, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Descrição:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(484, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Categoria:";
            // 
            // cbDescricao
            // 
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(149, 28);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(206, 28);
            this.cbDescricao.TabIndex = 44;
            this.cbDescricao.DropDown += new System.EventHandler(this.cbDescricao_DropDown);
            this.cbDescricao.SelectedValueChanged += new System.EventHandler(this.cbDescricao_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Pertencente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nº de série:";
            // 
            // _txtPertencente
            // 
            this._txtPertencente.Enabled = false;
            this._txtPertencente.Location = new System.Drawing.Point(572, 87);
            this._txtPertencente.Name = "_txtPertencente";
            this._txtPertencente.Size = new System.Drawing.Size(206, 26);
            this._txtPertencente.TabIndex = 29;
            // 
            // _txtCategoria
            // 
            this._txtCategoria.Enabled = false;
            this._txtCategoria.Location = new System.Drawing.Point(572, 28);
            this._txtCategoria.Name = "_txtCategoria";
            this._txtCategoria.Size = new System.Drawing.Size(206, 26);
            this._txtCategoria.TabIndex = 28;
            // 
            // _txtEstado
            // 
            this._txtEstado.Enabled = false;
            this._txtEstado.Location = new System.Drawing.Point(149, 87);
            this._txtEstado.Name = "_txtEstado";
            this._txtEstado.Size = new System.Drawing.Size(206, 26);
            this._txtEstado.TabIndex = 27;
            // 
            // _txtPatrimonio
            // 
            this._txtPatrimonio.Enabled = false;
            this._txtPatrimonio.Location = new System.Drawing.Point(572, 146);
            this._txtPatrimonio.Name = "_txtPatrimonio";
            this._txtPatrimonio.Size = new System.Drawing.Size(206, 26);
            this._txtPatrimonio.TabIndex = 26;
            // 
            // _txtNSerie
            // 
            this._txtNSerie.Enabled = false;
            this._txtNSerie.Location = new System.Drawing.Point(149, 148);
            this._txtNSerie.Name = "_txtNSerie";
            this._txtNSerie.Size = new System.Drawing.Size(206, 26);
            this._txtNSerie.TabIndex = 25;
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
            // dtpRetirada
            // 
            this.dtpRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.dtpRetirada.Location = new System.Drawing.Point(572, 77);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(206, 26);
            this.dtpRetirada.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(105, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "RG:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(438, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "Data de retirada:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(650, 316);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 31);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(480, 316);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(138, 31);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "OK";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmEditarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.pnTermo);
            this.Controls.Add(this.pnEquipamento);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditarBase";
            this.Load += new System.EventHandler(this.frmEditarBase_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnEquipamento.ResumeLayout(false);
            this.pnEquipamento.PerformLayout();
            this.pnTermo.ResumeLayout(false);
            this.pnTermo.PerformLayout();
            this.gbTermo.ResumeLayout(false);
            this.gbTermo.PerformLayout();
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
        private System.Windows.Forms.Panel pnTermo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDescricao;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button btnTermo_Slider;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.CheckBox cbDevolvido;
    }
}