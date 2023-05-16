namespace HSA_Estoque
{
    partial class FormViewProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewProdutos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimparFiltro = new System.Windows.Forms.Button();
            this.buttonPesquisaPorDescricao = new System.Windows.Forms.Button();
            this.textBoxPesquisaPordescricao = new System.Windows.Forms.TextBox();
            this.buttonPesquisaPorCodigo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPesquisaPorCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLimparFiltro);
            this.groupBox1.Controls.Add(this.buttonPesquisaPorDescricao);
            this.groupBox1.Controls.Add(this.textBoxPesquisaPordescricao);
            this.groupBox1.Controls.Add(this.buttonPesquisaPorCodigo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxPesquisaPorCodigo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa produto";
            // 
            // buttonLimparFiltro
            // 
            this.buttonLimparFiltro.Location = new System.Drawing.Point(93, 111);
            this.buttonLimparFiltro.Name = "buttonLimparFiltro";
            this.buttonLimparFiltro.Size = new System.Drawing.Size(112, 29);
            this.buttonLimparFiltro.TabIndex = 10;
            this.buttonLimparFiltro.Text = "Limpar filtro";
            this.buttonLimparFiltro.UseVisualStyleBackColor = true;
            this.buttonLimparFiltro.Click += new System.EventHandler(this.buttonLimparFiltro_Click);
            // 
            // buttonPesquisaPorDescricao
            // 
            this.buttonPesquisaPorDescricao.Image = global::HCHL_Inventario.Properties.Resources.Pesquisar16x16;
            this.buttonPesquisaPorDescricao.Location = new System.Drawing.Point(361, 66);
            this.buttonPesquisaPorDescricao.Name = "buttonPesquisaPorDescricao";
            this.buttonPesquisaPorDescricao.Size = new System.Drawing.Size(32, 32);
            this.buttonPesquisaPorDescricao.TabIndex = 9;
            this.buttonPesquisaPorDescricao.UseVisualStyleBackColor = true;
            this.buttonPesquisaPorDescricao.Click += new System.EventHandler(this.buttonPesquisaPorDescricao_Click);
            // 
            // textBoxPesquisaPordescricao
            // 
            this.textBoxPesquisaPordescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaPordescricao.Location = new System.Drawing.Point(93, 69);
            this.textBoxPesquisaPordescricao.Name = "textBoxPesquisaPordescricao";
            this.textBoxPesquisaPordescricao.Size = new System.Drawing.Size(262, 26);
            this.textBoxPesquisaPordescricao.TabIndex = 8;
            // 
            // buttonPesquisaPorCodigo
            // 
            this.buttonPesquisaPorCodigo.Image = global::HCHL_Inventario.Properties.Resources.Pesquisar16x16;
            this.buttonPesquisaPorCodigo.Location = new System.Drawing.Point(361, 28);
            this.buttonPesquisaPorCodigo.Name = "buttonPesquisaPorCodigo";
            this.buttonPesquisaPorCodigo.Size = new System.Drawing.Size(32, 32);
            this.buttonPesquisaPorCodigo.TabIndex = 2;
            this.buttonPesquisaPorCodigo.UseVisualStyleBackColor = true;
            this.buttonPesquisaPorCodigo.Click += new System.EventHandler(this.buttonPesquisaPorCodigo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Descrição";
            // 
            // textBoxPesquisaPorCodigo
            // 
            this.textBoxPesquisaPorCodigo.Location = new System.Drawing.Point(93, 31);
            this.textBoxPesquisaPorCodigo.Name = "textBoxPesquisaPorCodigo";
            this.textBoxPesquisaPorCodigo.Size = new System.Drawing.Size(262, 26);
            this.textBoxPesquisaPorCodigo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cód.";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutos.AutoGenerateColumns = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeTotalDataGridViewTextBoxColumn,
            this.localizacaoDataGridViewTextBoxColumn,
            this.caixaDataGridViewTextBoxColumn});
            this.dataGridViewProdutos.DataSource = this.produtoBindingSource;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 172);
            this.dataGridViewProdutos.MultiSelect = false;
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(984, 545);
            this.dataGridViewProdutos.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 85;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeTotalDataGridViewTextBoxColumn
            // 
            this.quantidadeTotalDataGridViewTextBoxColumn.DataPropertyName = "quantidadeTotal";
            this.quantidadeTotalDataGridViewTextBoxColumn.HeaderText = "Qtd. atual";
            this.quantidadeTotalDataGridViewTextBoxColumn.Name = "quantidadeTotalDataGridViewTextBoxColumn";
            this.quantidadeTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localizacaoDataGridViewTextBoxColumn
            // 
            this.localizacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.localizacaoDataGridViewTextBoxColumn.DataPropertyName = "localizacao";
            this.localizacaoDataGridViewTextBoxColumn.HeaderText = "Localização";
            this.localizacaoDataGridViewTextBoxColumn.Name = "localizacaoDataGridViewTextBoxColumn";
            this.localizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.localizacaoDataGridViewTextBoxColumn.Width = 117;
            // 
            // caixaDataGridViewTextBoxColumn
            // 
            this.caixaDataGridViewTextBoxColumn.DataPropertyName = "caixa";
            this.caixaDataGridViewTextBoxColumn.HeaderText = "Caixa";
            this.caixaDataGridViewTextBoxColumn.Name = "caixaDataGridViewTextBoxColumn";
            this.caixaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(HSA_Estoque.Model.Produto);
            // 
            // FormViewProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormViewProdutos";
            this.Text = "HSA Estoque - visualizar insumos";
            this.Load += new System.EventHandler(this.FormViewProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPesquisaPorDescricao;
        private System.Windows.Forms.TextBox textBoxPesquisaPordescricao;
        private System.Windows.Forms.Button buttonPesquisaPorCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPesquisaPorCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLimparFiltro;
    }
}