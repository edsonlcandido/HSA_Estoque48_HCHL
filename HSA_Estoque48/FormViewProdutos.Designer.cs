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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPesquisaPordescricao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPesquisaPorCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonPesquisaPorDescricao = new System.Windows.Forms.Button();
            this.buttonPesquisaPorCodigo = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPesquisaPorDescricao);
            this.groupBox1.Controls.Add(this.textBoxPesquisaPordescricao);
            this.groupBox1.Controls.Add(this.buttonPesquisaPorCodigo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxPesquisaPorCodigo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa produto";
            // 
            // textBoxPesquisaPordescricao
            // 
            this.textBoxPesquisaPordescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaPordescricao.Location = new System.Drawing.Point(93, 69);
            this.textBoxPesquisaPordescricao.Name = "textBoxPesquisaPordescricao";
            this.textBoxPesquisaPordescricao.Size = new System.Drawing.Size(262, 26);
            this.textBoxPesquisaPordescricao.TabIndex = 8;
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
            // buttonPesquisaPorDescricao
            // 
            this.buttonPesquisaPorDescricao.Image = global::HSA_Estoque.Properties.Resources.Pesquisar16x16;
            this.buttonPesquisaPorDescricao.Location = new System.Drawing.Point(361, 66);
            this.buttonPesquisaPorDescricao.Name = "buttonPesquisaPorDescricao";
            this.buttonPesquisaPorDescricao.Size = new System.Drawing.Size(32, 32);
            this.buttonPesquisaPorDescricao.TabIndex = 9;
            this.buttonPesquisaPorDescricao.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisaPorCodigo
            // 
            this.buttonPesquisaPorCodigo.Image = global::HSA_Estoque.Properties.Resources.Pesquisar16x16;
            this.buttonPesquisaPorCodigo.Location = new System.Drawing.Point(361, 28);
            this.buttonPesquisaPorCodigo.Name = "buttonPesquisaPorCodigo";
            this.buttonPesquisaPorCodigo.Size = new System.Drawing.Size(32, 32);
            this.buttonPesquisaPorCodigo.TabIndex = 2;
            this.buttonPesquisaPorCodigo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewProdutos.MultiSelect = false;
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(984, 582);
            this.dataGridViewProdutos.TabIndex = 8;
            // 
            // FormViewProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormViewProdutos";
            this.Text = "HSA Estoque - visualizar insumos";
            this.Load += new System.EventHandler(this.FormViewProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
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
    }
}