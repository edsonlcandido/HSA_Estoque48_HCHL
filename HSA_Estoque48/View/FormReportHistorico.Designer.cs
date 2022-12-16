namespace HSA_Estoque.View
{
    partial class FormReportHistorico
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.historicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataMovimentacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeMovimentadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimentacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoCentroCustoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataMovimentacaoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.quantidadeMovimentadaDataGridViewTextBoxColumn,
            this.tipoMovimentacaoDataGridViewTextBoxColumn,
            this.produtoIdDataGridViewTextBoxColumn,
            this.produtoDescricao,
            this.solicitanteDataGridViewTextBoxColumn,
            this.pedidoCentroCustoDataGridViewTextBoxColumn,
            this.notaFiscalDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historicoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(932, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // historicoBindingSource
            // 
            this.historicoBindingSource.DataSource = typeof(HSA_Estoque.Model.Historico);
            // 
            // dataMovimentacaoDataGridViewTextBoxColumn
            // 
            this.dataMovimentacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataMovimentacaoDataGridViewTextBoxColumn.DataPropertyName = "dataMovimentacao";
            this.dataMovimentacaoDataGridViewTextBoxColumn.HeaderText = "Data da movimentação";
            this.dataMovimentacaoDataGridViewTextBoxColumn.Name = "dataMovimentacaoDataGridViewTextBoxColumn";
            this.dataMovimentacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataMovimentacaoDataGridViewTextBoxColumn.Width = 145;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuário";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeMovimentadaDataGridViewTextBoxColumn
            // 
            this.quantidadeMovimentadaDataGridViewTextBoxColumn.DataPropertyName = "quantidadeMovimentada";
            this.quantidadeMovimentadaDataGridViewTextBoxColumn.HeaderText = "Qtd. movimentada";
            this.quantidadeMovimentadaDataGridViewTextBoxColumn.Name = "quantidadeMovimentadaDataGridViewTextBoxColumn";
            this.quantidadeMovimentadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMovimentacaoDataGridViewTextBoxColumn
            // 
            this.tipoMovimentacaoDataGridViewTextBoxColumn.DataPropertyName = "tipoMovimentacao";
            this.tipoMovimentacaoDataGridViewTextBoxColumn.HeaderText = "Tipo de movimentação";
            this.tipoMovimentacaoDataGridViewTextBoxColumn.Name = "tipoMovimentacaoDataGridViewTextBoxColumn";
            this.tipoMovimentacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            this.produtoIdDataGridViewTextBoxColumn.DataPropertyName = "produtoId";
            this.produtoIdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            this.produtoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoDescricao
            // 
            this.produtoDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.produtoDescricao.DataPropertyName = "produtoDescricao";
            this.produtoDescricao.HeaderText = "Descrição";
            this.produtoDescricao.Name = "produtoDescricao";
            this.produtoDescricao.ReadOnly = true;
            this.produtoDescricao.Width = 88;
            // 
            // solicitanteDataGridViewTextBoxColumn
            // 
            this.solicitanteDataGridViewTextBoxColumn.DataPropertyName = "solicitante";
            this.solicitanteDataGridViewTextBoxColumn.HeaderText = "Solicitante";
            this.solicitanteDataGridViewTextBoxColumn.Name = "solicitanteDataGridViewTextBoxColumn";
            this.solicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidoCentroCustoDataGridViewTextBoxColumn
            // 
            this.pedidoCentroCustoDataGridViewTextBoxColumn.DataPropertyName = "pedidoCentroCusto";
            this.pedidoCentroCustoDataGridViewTextBoxColumn.HeaderText = "Pedido ou C/C";
            this.pedidoCentroCustoDataGridViewTextBoxColumn.Name = "pedidoCentroCustoDataGridViewTextBoxColumn";
            this.pedidoCentroCustoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaFiscalDataGridViewTextBoxColumn
            // 
            this.notaFiscalDataGridViewTextBoxColumn.DataPropertyName = "notaFiscal";
            this.notaFiscalDataGridViewTextBoxColumn.HeaderText = "No.  NF";
            this.notaFiscalDataGridViewTextBoxColumn.Name = "notaFiscalDataGridViewTextBoxColumn";
            this.notaFiscalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "Obs.";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormReportHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormReportHistorico";
            this.Text = "FormReportHistorico";
            this.Load += new System.EventHandler(this.FormReportHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historicoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMovimentacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeMovimentadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimentacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoCentroCustoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaFiscalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
    }
}