namespace GeradorDeProposta
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosDataSet = new GeradorDeProposta.DadosDataSet();
            this.ddlProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btAdicionarItem = new System.Windows.Forms.Button();
            this.ucData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btSalvarProposta = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.cbComodato = new System.Windows.Forms.CheckBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCondicao = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.ddlPeriodo = new System.Windows.Forms.ComboBox();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.ddlCondicao = new System.Windows.Forms.ComboBox();
            this.condicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCodCli = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.periodoTableAdapter = new GeradorDeProposta.DadosDataSetTableAdapters.PeriodoTableAdapter();
            this.produtoTableAdapter = new GeradorDeProposta.DadosDataSetTableAdapters.ProdutoTableAdapter();
            this.condicaoTableAdapter = new GeradorDeProposta.DadosDataSetTableAdapters.CondicaoTableAdapter();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.cbTradein = new System.Windows.Forms.CheckBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cbGeraResDom = new System.Windows.Forms.CheckBox();
            this.cbGeraFornMerc = new System.Windows.Forms.CheckBox();
            this.cbGeraTradein = new System.Windows.Forms.CheckBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(70, 23);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(296, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(70, 55);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(257, 20);
            this.txtContato.TabIndex = 2;
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(441, 55);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(291, 20);
            this.txtRep.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(20, 62);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(44, 13);
            this.lblContato.TabIndex = 4;
            this.lblContato.Text = "Contato";
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.Location = new System.Drawing.Point(358, 58);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(77, 13);
            this.lblRepresentante.TabIndex = 5;
            this.lblRepresentante.Text = "Representante";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(643, 310);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(89, 23);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Preco", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtPreco.Location = new System.Drawing.Point(361, 88);
            this.txtPreco.MaxLength = 5;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(82, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dadosDataSet;
            // 
            // dadosDataSet
            // 
            this.dadosDataSet.DataSetName = "DadosDataSet";
            this.dadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ddlProduto
            // 
            this.ddlProduto.AutoCompleteCustomSource.AddRange(new string[] {
            "chapa milion",
            "chapa sdr",
            "chapa sr",
            "chapa redonda"});
            this.ddlProduto.DataSource = this.produtoBindingSource;
            this.ddlProduto.DisplayMember = "Nome";
            this.ddlProduto.FormattingEnabled = true;
            this.ddlProduto.Location = new System.Drawing.Point(70, 90);
            this.ddlProduto.Name = "ddlProduto";
            this.ddlProduto.Size = new System.Drawing.Size(201, 21);
            this.ddlProduto.TabIndex = 4;
            this.ddlProduto.ValueMember = "Id";
            this.ddlProduto.SelectedIndexChanged += new System.EventHandler(this.ddlProduto_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(20, 93);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 53;
            this.lblProduto.Text = "Produto";
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AllowUserToOrderColumns = true;
            this.dgProdutos.AllowUserToResizeColumns = false;
            this.dgProdutos.AllowUserToResizeRows = false;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(23, 182);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(709, 115);
            this.dgProdutos.TabIndex = 52;
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.Location = new System.Drawing.Point(643, 120);
            this.btAdicionarItem.Name = "btAdicionarItem";
            this.btAdicionarItem.Size = new System.Drawing.Size(89, 23);
            this.btAdicionarItem.TabIndex = 10;
            this.btAdicionarItem.Text = "Incluir";
            this.btAdicionarItem.UseVisualStyleBackColor = true;
            this.btAdicionarItem.Click += new System.EventHandler(this.btAdicionarItem_Click);
            // 
            // ucData
            // 
            this.ucData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ucData.Location = new System.Drawing.Point(558, 23);
            this.ucData.Name = "ucData";
            this.ucData.Size = new System.Drawing.Size(174, 20);
            this.ucData.TabIndex = 55;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(523, 28);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 56;
            this.lblData.Text = "Data";
            // 
            // btSalvarProposta
            // 
            this.btSalvarProposta.Location = new System.Drawing.Point(255, 449);
            this.btSalvarProposta.Name = "btSalvarProposta";
            this.btSalvarProposta.Size = new System.Drawing.Size(248, 23);
            this.btSalvarProposta.TabIndex = 12;
            this.btSalvarProposta.Text = "Salvar Proposta em PDF";
            this.btSalvarProposta.UseVisualStyleBackColor = true;
            this.btSalvarProposta.Click += new System.EventHandler(this.btSalvarProposta_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.produtoBindingSource, "PermiteComodato", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVolume.Location = new System.Drawing.Point(420, 120);
            this.txtVolume.MaxLength = 5;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(63, 20);
            this.txtVolume.TabIndex = 8;
            // 
            // cbComodato
            // 
            this.cbComodato.AutoSize = true;
            this.cbComodato.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.produtoBindingSource, "PermiteComodato", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbComodato.Location = new System.Drawing.Point(72, 122);
            this.cbComodato.Name = "cbComodato";
            this.cbComodato.Size = new System.Drawing.Size(74, 17);
            this.cbComodato.TabIndex = 7;
            this.cbComodato.Text = "Comodato";
            this.cbComodato.UseVisualStyleBackColor = true;
            this.cbComodato.CheckedChanged += new System.EventHandler(this.cbComodato_CheckedChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(280, 93);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(41, 13);
            this.lblPreco.TabIndex = 60;
            this.lblPreco.Text = "Preço: ";
            // 
            // lblCondicao
            // 
            this.lblCondicao.AutoSize = true;
            this.lblCondicao.Location = new System.Drawing.Point(451, 92);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(52, 13);
            this.lblCondicao.TabIndex = 62;
            this.lblCondicao.Text = "Condição";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(301, 123);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(113, 13);
            this.lblVolume.TabIndex = 63;
            this.lblVolume.Text = "Volume Mensal em m2";
            // 
            // ddlPeriodo
            // 
            this.ddlPeriodo.AutoCompleteCustomSource.AddRange(new string[] {
            "chapa milion",
            "chapa sdr",
            "chapa sr",
            "chapa redonda"});
            this.ddlPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.produtoBindingSource, "PermiteComodato", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ddlPeriodo.DataSource = this.periodoBindingSource;
            this.ddlPeriodo.DisplayMember = "Periodo";
            this.ddlPeriodo.FormattingEnabled = true;
            this.ddlPeriodo.Location = new System.Drawing.Point(548, 120);
            this.ddlPeriodo.Name = "ddlPeriodo";
            this.ddlPeriodo.Size = new System.Drawing.Size(93, 21);
            this.ddlPeriodo.TabIndex = 9;
            this.ddlPeriodo.ValueMember = "Id";
            // 
            // periodoBindingSource
            // 
            this.periodoBindingSource.DataMember = "Periodo";
            this.periodoBindingSource.DataSource = this.dadosDataSet;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(498, 123);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(45, 13);
            this.lblPeriodo.TabIndex = 66;
            this.lblPeriodo.Text = "Período";
            // 
            // ddlCondicao
            // 
            this.ddlCondicao.AutoCompleteCustomSource.AddRange(new string[] {
            "chapa milion",
            "chapa sdr",
            "chapa sr",
            "chapa redonda"});
            this.ddlCondicao.DataSource = this.condicaoBindingSource;
            this.ddlCondicao.DisplayMember = "Nome";
            this.ddlCondicao.FormattingEnabled = true;
            this.ddlCondicao.Location = new System.Drawing.Point(509, 88);
            this.ddlCondicao.Name = "ddlCondicao";
            this.ddlCondicao.Size = new System.Drawing.Size(223, 21);
            this.ddlCondicao.TabIndex = 6;
            this.ddlCondicao.ValueMember = "ProdutoID";
            // 
            // condicaoBindingSource
            // 
            this.condicaoBindingSource.DataMember = "Condicao";
            this.condicaoBindingSource.DataSource = this.dadosDataSet;
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(381, 26);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(40, 13);
            this.lblCodCli.TabIndex = 69;
            this.lblCodCli.Text = "Código";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(431, 23);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(72, 20);
            this.txtCodCli.TabIndex = 1;
            // 
            // periodoTableAdapter
            // 
            this.periodoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // condicaoTableAdapter
            // 
            this.condicaoTableAdapter.ClearBeforeFill = true;
            // 
            // txtImagem
            // 
            this.txtImagem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Imagem", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtImagem.Location = new System.Drawing.Point(2, 452);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(36, 20);
            this.txtImagem.TabIndex = 70;
            // 
            // txtMoeda
            // 
            this.txtMoeda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Moeda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMoeda.Enabled = false;
            this.txtMoeda.Location = new System.Drawing.Point(324, 88);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(34, 20);
            this.txtMoeda.TabIndex = 71;
            // 
            // cbTradein
            // 
            this.cbTradein.AutoSize = true;
            this.cbTradein.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.produtoBindingSource, "PermiteTradein", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbTradein.Location = new System.Drawing.Point(72, 159);
            this.cbTradein.Name = "cbTradein";
            this.cbTradein.Size = new System.Drawing.Size(65, 17);
            this.cbTradein.TabIndex = 72;
            this.cbTradein.Text = "Trade-in";
            this.cbTradein.UseVisualStyleBackColor = true;
            this.cbTradein.CheckedChanged += new System.EventHandler(this.cbTradein_CheckedChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(20, 361);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 73;
            this.lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(96, 361);
            this.txtObs.MaxLength = 415;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(636, 54);
            this.txtObs.TabIndex = 74;
            this.txtObs.TextChanged += new System.EventHandler(this.txtObs_TextChanged);
            // 
            // cbGeraResDom
            // 
            this.cbGeraResDom.AutoSize = true;
            this.cbGeraResDom.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.produtoBindingSource, "PermiteTradein", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbGeraResDom.Location = new System.Drawing.Point(473, 421);
            this.cbGeraResDom.Name = "cbGeraResDom";
            this.cbGeraResDom.Size = new System.Drawing.Size(211, 17);
            this.cbGeraResDom.TabIndex = 75;
            this.cbGeraResDom.Text = "Gerar Contrato de Reserva de Domínio";
            this.cbGeraResDom.UseVisualStyleBackColor = true;
            // 
            // cbGeraFornMerc
            // 
            this.cbGeraFornMerc.AutoSize = true;
            this.cbGeraFornMerc.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.produtoBindingSource, "PermiteTradein", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbGeraFornMerc.Location = new System.Drawing.Point(244, 421);
            this.cbGeraFornMerc.Name = "cbGeraFornMerc";
            this.cbGeraFornMerc.Size = new System.Drawing.Size(223, 17);
            this.cbGeraFornMerc.TabIndex = 76;
            this.cbGeraFornMerc.Text = "Gerar Contrato de Fornecimento Mercantil";
            this.cbGeraFornMerc.UseVisualStyleBackColor = true;
            // 
            // cbGeraTradein
            // 
            this.cbGeraTradein.AutoSize = true;
            this.cbGeraTradein.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.produtoBindingSource, "PermiteTradein", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbGeraTradein.Location = new System.Drawing.Point(96, 421);
            this.cbGeraTradein.Name = "cbGeraTradein";
            this.cbGeraTradein.Size = new System.Drawing.Size(142, 17);
            this.cbGeraTradein.TabIndex = 77;
            this.cbGeraTradein.Text = "Gerar Termo de Trade-in";
            this.cbGeraTradein.UseVisualStyleBackColor = true;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(178, 122);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblEntrada.TabIndex = 79;
            this.lblEntrada.Text = "Entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(223, 119);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(72, 20);
            this.txtEntrada.TabIndex = 78;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(753, 488);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.cbGeraTradein);
            this.Controls.Add(this.cbGeraFornMerc);
            this.Controls.Add(this.cbGeraResDom);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.cbTradein);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtImagem);
            this.Controls.Add(this.lblCodCli);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.ddlCondicao);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.ddlPeriodo);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblCondicao);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.cbComodato);
            this.Controls.Add(this.btSalvarProposta);
            this.Controls.Add(this.ucData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.ddlProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btAdicionarItem);
            this.Controls.Add(this.lblRepresentante);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtCliente);
            this.Name = "Principal";
            this.Text = "Gerador de Proposta IBF";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblRepresentante;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox ddlProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btAdicionarItem;
        private System.Windows.Forms.DateTimePicker ucData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btSalvarProposta;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.CheckBox cbComodato;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCondicao;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ComboBox ddlPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox ddlCondicao;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.TextBox txtCodCli;
        private DadosDataSetTableAdapters.PeriodoTableAdapter periodoTableAdapter;
        private DadosDataSet dadosDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DadosDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource condicaoBindingSource;
        private DadosDataSetTableAdapters.CondicaoTableAdapter condicaoTableAdapter;
        private System.Windows.Forms.BindingSource periodoBindingSource;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.CheckBox cbTradein;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.CheckBox cbGeraResDom;
        private System.Windows.Forms.CheckBox cbGeraFornMerc;
        private System.Windows.Forms.CheckBox cbGeraTradein;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtEntrada;
    }
}

