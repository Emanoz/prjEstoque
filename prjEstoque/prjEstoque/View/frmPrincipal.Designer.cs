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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnList = new System.Windows.Forms.Panel();
            this.btnList_Arrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnReport = new System.Windows.Forms.Panel();
            this.btnRep_Arrow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSlide = new System.Windows.Forms.Button();
            this.pnHome = new System.Windows.Forms.Panel();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.pnGroup_Op = new System.Windows.Forms.Panel();
            this.pnGb_Prod = new System.Windows.Forms.Panel();
            this.txtProd_Nome = new System.Windows.Forms.GroupBox();
            this.pnList_Prod = new System.Windows.Forms.Panel();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.prod_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_Cadastrado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnList_Forn = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.forn_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_Tipo_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProd_Slider = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnList.SuspendLayout();
            this.pnReport.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            this.pnGroup_Op.SuspendLayout();
            this.pnGb_Prod.SuspendLayout();
            this.txtProd_Nome.SuspendLayout();
            this.pnList_Prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.pnList_Forn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnLeft.Controls.Add(this.panel2);
            this.pnLeft.Controls.Add(this.btnCreate);
            this.pnLeft.Controls.Add(this.btnSlide);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 38);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(251, 662);
            this.pnLeft.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnList);
            this.panel2.Controls.Add(this.pnReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 478);
            this.panel2.TabIndex = 2;
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.btnList_Arrow);
            this.pnList.Controls.Add(this.label1);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnList.Location = new System.Drawing.Point(0, 54);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(251, 54);
            this.pnList.TabIndex = 0;
            // 
            // btnList_Arrow
            // 
            this.btnList_Arrow.FlatAppearance.BorderSize = 0;
            this.btnList_Arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList_Arrow.Image = global::prjEstoque.Properties.Resources.icons8_chevron_right_16_1_;
            this.btnList_Arrow.Location = new System.Drawing.Point(3, 2);
            this.btnList_Arrow.Name = "btnList_Arrow";
            this.btnList_Arrow.Size = new System.Drawing.Size(30, 51);
            this.btnList_Arrow.TabIndex = 5;
            this.btnList_Arrow.UseVisualStyleBackColor = true;
            this.btnList_Arrow.Click += new System.EventHandler(this.btnList_Arrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listagem";
            // 
            // pnReport
            // 
            this.pnReport.Controls.Add(this.btnRep_Arrow);
            this.pnReport.Controls.Add(this.label2);
            this.pnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnReport.Location = new System.Drawing.Point(0, 0);
            this.pnReport.Name = "pnReport";
            this.pnReport.Size = new System.Drawing.Size(251, 54);
            this.pnReport.TabIndex = 2;
            // 
            // btnRep_Arrow
            // 
            this.btnRep_Arrow.FlatAppearance.BorderSize = 0;
            this.btnRep_Arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRep_Arrow.Image = global::prjEstoque.Properties.Resources.icons8_chevron_right_16_1_;
            this.btnRep_Arrow.Location = new System.Drawing.Point(3, 1);
            this.btnRep_Arrow.Name = "btnRep_Arrow";
            this.btnRep_Arrow.Size = new System.Drawing.Size(30, 51);
            this.btnRep_Arrow.TabIndex = 7;
            this.btnRep_Arrow.UseVisualStyleBackColor = true;
            this.btnRep_Arrow.Click += new System.EventHandler(this.btnRep_Arrow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Relatório";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = global::prjEstoque.Properties.Resources.icons8_movimento_de_estoque_50;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 119);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(251, 65);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Cadastro";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSlide.FlatAppearance.BorderSize = 0;
            this.btnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide.Image = global::prjEstoque.Properties.Resources.icons8_no_inventário_40;
            this.btnSlide.Location = new System.Drawing.Point(0, 0);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(251, 81);
            this.btnSlide.TabIndex = 0;
            this.btnSlide.UseVisualStyleBackColor = true;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
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
            // pnCadastro
            // 
            this.pnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnCadastro.Controls.Add(this.pnGroup_Op);
            this.pnCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCadastro.Location = new System.Drawing.Point(251, 38);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(849, 662);
            this.pnCadastro.TabIndex = 3;
            // 
            // pnGroup_Op
            // 
            this.pnGroup_Op.AutoScroll = true;
            this.pnGroup_Op.Controls.Add(this.pnGb_Prod);
            this.pnGroup_Op.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnGroup_Op.Location = new System.Drawing.Point(0, 48);
            this.pnGroup_Op.Name = "pnGroup_Op";
            this.pnGroup_Op.Size = new System.Drawing.Size(849, 614);
            this.pnGroup_Op.TabIndex = 0;
            // 
            // pnGb_Prod
            // 
            this.pnGb_Prod.Controls.Add(this.txtProd_Nome);
            this.pnGb_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGb_Prod.Location = new System.Drawing.Point(0, 0);
            this.pnGb_Prod.Name = "pnGb_Prod";
            this.pnGb_Prod.Size = new System.Drawing.Size(849, 65);
            this.pnGb_Prod.TabIndex = 1;
            // 
            // txtProd_Nome
            // 
            this.txtProd_Nome.Controls.Add(this.btnProd_Slider);
            this.txtProd_Nome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProd_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd_Nome.ForeColor = System.Drawing.Color.White;
            this.txtProd_Nome.Location = new System.Drawing.Point(0, 0);
            this.txtProd_Nome.Name = "txtProd_Nome";
            this.txtProd_Nome.Size = new System.Drawing.Size(849, 28);
            this.txtProd_Nome.TabIndex = 0;
            this.txtProd_Nome.TabStop = false;
            this.txtProd_Nome.Text = "(exemplo)";
            // 
            // pnList_Prod
            // 
            this.pnList_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnList_Prod.Controls.Add(this.dgvFornecedores);
            this.pnList_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList_Prod.Location = new System.Drawing.Point(251, 38);
            this.pnList_Prod.Name = "pnList_Prod";
            this.pnList_Prod.Size = new System.Drawing.Size(849, 662);
            this.pnList_Prod.TabIndex = 3;
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.AllowUserToResizeRows = false;
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFornecedores.ColumnHeadersHeight = 35;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_Id,
            this.prod_Nome,
            this.prod_Preco,
            this.prod_Quantidade,
            this.prod_Cadastrado_em});
            this.dgvFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFornecedores.Location = new System.Drawing.Point(0, 0);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.Size = new System.Drawing.Size(849, 662);
            this.dgvFornecedores.TabIndex = 1;
            // 
            // prod_Id
            // 
            this.prod_Id.HeaderText = "Cód.";
            this.prod_Id.Name = "prod_Id";
            this.prod_Id.ReadOnly = true;
            // 
            // prod_Nome
            // 
            this.prod_Nome.HeaderText = "Nome";
            this.prod_Nome.Name = "prod_Nome";
            this.prod_Nome.ReadOnly = true;
            this.prod_Nome.Width = 170;
            // 
            // prod_Preco
            // 
            this.prod_Preco.HeaderText = "Preço";
            this.prod_Preco.Name = "prod_Preco";
            this.prod_Preco.ReadOnly = true;
            // 
            // prod_Quantidade
            // 
            this.prod_Quantidade.HeaderText = "Estoque";
            this.prod_Quantidade.Name = "prod_Quantidade";
            this.prod_Quantidade.ReadOnly = true;
            // 
            // prod_Cadastrado_em
            // 
            this.prod_Cadastrado_em.HeaderText = "Cadastrado em:";
            this.prod_Cadastrado_em.Name = "prod_Cadastrado_em";
            this.prod_Cadastrado_em.ReadOnly = true;
            this.prod_Cadastrado_em.Width = 200;
            // 
            // pnList_Forn
            // 
            this.pnList_Forn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnList_Forn.Controls.Add(this.dgvProdutos);
            this.pnList_Forn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList_Forn.Location = new System.Drawing.Point(251, 38);
            this.pnList_Forn.Name = "pnList_Forn";
            this.pnList_Forn.Size = new System.Drawing.Size(849, 662);
            this.pnList_Forn.TabIndex = 4;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProdutos.ColumnHeadersHeight = 35;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forn_Id,
            this.forn_Nome,
            this.forn_Telefone,
            this.forn_Email,
            this.forn_Tipo_Prod,
            this.forn_Cpf,
            this.forn_Cnpj,
            this.forn_Cep});
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(849, 662);
            this.dgvProdutos.TabIndex = 0;
            // 
            // forn_Id
            // 
            this.forn_Id.HeaderText = "Cód.";
            this.forn_Id.Name = "forn_Id";
            this.forn_Id.ReadOnly = true;
            this.forn_Id.Width = 130;
            // 
            // forn_Nome
            // 
            this.forn_Nome.HeaderText = "Nome";
            this.forn_Nome.Name = "forn_Nome";
            this.forn_Nome.ReadOnly = true;
            this.forn_Nome.Width = 200;
            // 
            // forn_Telefone
            // 
            this.forn_Telefone.HeaderText = "Telefone";
            this.forn_Telefone.Name = "forn_Telefone";
            this.forn_Telefone.ReadOnly = true;
            this.forn_Telefone.Width = 130;
            // 
            // forn_Email
            // 
            this.forn_Email.HeaderText = "Email";
            this.forn_Email.Name = "forn_Email";
            this.forn_Email.ReadOnly = true;
            this.forn_Email.Width = 250;
            // 
            // forn_Tipo_Prod
            // 
            this.forn_Tipo_Prod.HeaderText = "Tipo do Produto";
            this.forn_Tipo_Prod.Name = "forn_Tipo_Prod";
            this.forn_Tipo_Prod.ReadOnly = true;
            this.forn_Tipo_Prod.Width = 200;
            // 
            // forn_Cpf
            // 
            this.forn_Cpf.HeaderText = "CPF";
            this.forn_Cpf.Name = "forn_Cpf";
            this.forn_Cpf.ReadOnly = true;
            this.forn_Cpf.Width = 130;
            // 
            // forn_Cnpj
            // 
            this.forn_Cnpj.HeaderText = "CNPJ";
            this.forn_Cnpj.Name = "forn_Cnpj";
            this.forn_Cnpj.ReadOnly = true;
            this.forn_Cnpj.Width = 140;
            // 
            // forn_Cep
            // 
            this.forn_Cep.HeaderText = "CEP";
            this.forn_Cep.Name = "forn_Cep";
            this.forn_Cep.ReadOnly = true;
            this.forn_Cep.Width = 80;
            // 
            // btnProd_Slider
            // 
            this.btnProd_Slider.FlatAppearance.BorderSize = 0;
            this.btnProd_Slider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd_Slider.Image = global::prjEstoque.Properties.Resources.icons8_chevron_esquerda_16;
            this.btnProd_Slider.Location = new System.Drawing.Point(805, 10);
            this.btnProd_Slider.Name = "btnProd_Slider";
            this.btnProd_Slider.Size = new System.Drawing.Size(30, 16);
            this.btnProd_Slider.TabIndex = 8;
            this.btnProd_Slider.UseVisualStyleBackColor = true;
            this.btnProd_Slider.Click += new System.EventHandler(this.btnProd_Slider_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnCadastro);
            this.Controls.Add(this.pnList_Prod);
            this.Controls.Add(this.pnList_Forn);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnList.ResumeLayout(false);
            this.pnList.PerformLayout();
            this.pnReport.ResumeLayout(false);
            this.pnReport.PerformLayout();
            this.pnCadastro.ResumeLayout(false);
            this.pnGroup_Op.ResumeLayout(false);
            this.pnGb_Prod.ResumeLayout(false);
            this.txtProd_Nome.ResumeLayout(false);
            this.pnList_Prod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.pnList_Forn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
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
        private System.Windows.Forms.Panel pnReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSlide;
        private System.Windows.Forms.Panel pnCadastro;
        private System.Windows.Forms.Panel pnGroup_Op;
        private System.Windows.Forms.Panel pnGb_Prod;
        private System.Windows.Forms.GroupBox txtProd_Nome;
        private System.Windows.Forms.Panel pnList_Prod;
        private System.Windows.Forms.Panel pnList_Forn;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Button btnList_Arrow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRep_Arrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_Cadastrado_em;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_Tipo_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_Cep;
        private System.Windows.Forms.Button btnProd_Slider;
    }
}

