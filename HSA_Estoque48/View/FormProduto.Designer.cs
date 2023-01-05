namespace HSA_Estoque.View
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProdutoId = new System.Windows.Forms.TextBox();
            this.textBoxProdutoDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProdutoQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.labelQtdInicial = new System.Windows.Forms.Label();
            this.textBoxProdutoQuantidadeMinima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProdutoQuantidadeMaxima = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProdutoLeadTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxUnidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProdutoLocalizacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxProdutoCaixa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxInseridoPor = new System.Windows.Forms.TextBox();
            this.labelInseridoPor = new System.Windows.Forms.Label();
            this.textBoxDataInclusão = new System.Windows.Forms.TextBox();
            this.labelDataInclusao = new System.Windows.Forms.Label();
            this.buttonEditarProduto = new System.Windows.Forms.Button();
            this.buttonAdicionaProduto = new System.Windows.Forms.Button();
            this.buttonAdministrarTipo = new System.Windows.Forms.Button();
            this.buttonAdministrarUnidade = new System.Windows.Forms.Button();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // textBoxProdutoId
            // 
            this.textBoxProdutoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxProdutoId.Location = new System.Drawing.Point(142, 16);
            this.textBoxProdutoId.Name = "textBoxProdutoId";
            this.textBoxProdutoId.Size = new System.Drawing.Size(200, 26);
            this.textBoxProdutoId.TabIndex = 0;
            // 
            // textBoxProdutoDescricao
            // 
            this.textBoxProdutoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxProdutoDescricao.Location = new System.Drawing.Point(142, 48);
            this.textBoxProdutoDescricao.Name = "textBoxProdutoDescricao";
            this.textBoxProdutoDescricao.Size = new System.Drawing.Size(430, 26);
            this.textBoxProdutoDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // textBoxProdutoQuantidadeTotal
            // 
            this.textBoxProdutoQuantidadeTotal.Location = new System.Drawing.Point(142, 80);
            this.textBoxProdutoQuantidadeTotal.Name = "textBoxProdutoQuantidadeTotal";
            this.textBoxProdutoQuantidadeTotal.Size = new System.Drawing.Size(100, 26);
            this.textBoxProdutoQuantidadeTotal.TabIndex = 2;
            // 
            // labelQtdInicial
            // 
            this.labelQtdInicial.AutoSize = true;
            this.labelQtdInicial.Location = new System.Drawing.Point(12, 84);
            this.labelQtdInicial.Name = "labelQtdInicial";
            this.labelQtdInicial.Size = new System.Drawing.Size(81, 18);
            this.labelQtdInicial.TabIndex = 4;
            this.labelQtdInicial.Text = "Qtd. inicial";
            // 
            // textBoxProdutoQuantidadeMinima
            // 
            this.textBoxProdutoQuantidadeMinima.Location = new System.Drawing.Point(142, 112);
            this.textBoxProdutoQuantidadeMinima.Name = "textBoxProdutoQuantidadeMinima";
            this.textBoxProdutoQuantidadeMinima.Size = new System.Drawing.Size(100, 26);
            this.textBoxProdutoQuantidadeMinima.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Qtd. mínima";
            // 
            // textBoxProdutoQuantidadeMaxima
            // 
            this.textBoxProdutoQuantidadeMaxima.Location = new System.Drawing.Point(142, 144);
            this.textBoxProdutoQuantidadeMaxima.Name = "textBoxProdutoQuantidadeMaxima";
            this.textBoxProdutoQuantidadeMaxima.Size = new System.Drawing.Size(100, 26);
            this.textBoxProdutoQuantidadeMaxima.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Qtd. máxima";
            // 
            // textBoxProdutoLeadTime
            // 
            this.textBoxProdutoLeadTime.Location = new System.Drawing.Point(142, 176);
            this.textBoxProdutoLeadTime.Name = "textBoxProdutoLeadTime";
            this.textBoxProdutoLeadTime.Size = new System.Drawing.Size(100, 26);
            this.textBoxProdutoLeadTime.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lead time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(142, 208);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(200, 26);
            this.comboBoxTipo.TabIndex = 6;
            // 
            // comboBoxUnidade
            // 
            this.comboBoxUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidade.FormattingEnabled = true;
            this.comboBoxUnidade.Location = new System.Drawing.Point(142, 240);
            this.comboBoxUnidade.Name = "comboBoxUnidade";
            this.comboBoxUnidade.Size = new System.Drawing.Size(100, 26);
            this.comboBoxUnidade.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Unidade";
            // 
            // textBoxProdutoLocalizacao
            // 
            this.textBoxProdutoLocalizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxProdutoLocalizacao.Location = new System.Drawing.Point(142, 272);
            this.textBoxProdutoLocalizacao.Name = "textBoxProdutoLocalizacao";
            this.textBoxProdutoLocalizacao.Size = new System.Drawing.Size(200, 26);
            this.textBoxProdutoLocalizacao.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Localização";
            // 
            // textBoxProdutoCaixa
            // 
            this.textBoxProdutoCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxProdutoCaixa.Location = new System.Drawing.Point(142, 304);
            this.textBoxProdutoCaixa.Name = "textBoxProdutoCaixa";
            this.textBoxProdutoCaixa.Size = new System.Drawing.Size(200, 26);
            this.textBoxProdutoCaixa.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Caixa";
            // 
            // textBoxInseridoPor
            // 
            this.textBoxInseridoPor.Enabled = false;
            this.textBoxInseridoPor.Location = new System.Drawing.Point(142, 336);
            this.textBoxInseridoPor.Name = "textBoxInseridoPor";
            this.textBoxInseridoPor.Size = new System.Drawing.Size(200, 26);
            this.textBoxInseridoPor.TabIndex = 10;
            // 
            // labelInseridoPor
            // 
            this.labelInseridoPor.AutoSize = true;
            this.labelInseridoPor.Location = new System.Drawing.Point(12, 340);
            this.labelInseridoPor.Name = "labelInseridoPor";
            this.labelInseridoPor.Size = new System.Drawing.Size(90, 18);
            this.labelInseridoPor.TabIndex = 20;
            this.labelInseridoPor.Text = "Inserido por";
            // 
            // textBoxDataInclusão
            // 
            this.textBoxDataInclusão.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxDataInclusão.Enabled = false;
            this.textBoxDataInclusão.Location = new System.Drawing.Point(142, 368);
            this.textBoxDataInclusão.Name = "textBoxDataInclusão";
            this.textBoxDataInclusão.Size = new System.Drawing.Size(100, 26);
            this.textBoxDataInclusão.TabIndex = 11;
            // 
            // labelDataInclusao
            // 
            this.labelDataInclusao.AutoSize = true;
            this.labelDataInclusao.Location = new System.Drawing.Point(12, 372);
            this.labelDataInclusao.Name = "labelDataInclusao";
            this.labelDataInclusao.Size = new System.Drawing.Size(103, 18);
            this.labelDataInclusao.TabIndex = 22;
            this.labelDataInclusao.Text = "Data inclusão";
            // 
            // buttonEditarProduto
            // 
            this.buttonEditarProduto.Image = global::HSA_Estoque.Properties.Resources.Editar16x16;
            this.buttonEditarProduto.Location = new System.Drawing.Point(121, 477);
            this.buttonEditarProduto.Name = "buttonEditarProduto";
            this.buttonEditarProduto.Size = new System.Drawing.Size(100, 32);
            this.buttonEditarProduto.TabIndex = 13;
            this.buttonEditarProduto.Text = "Salvar";
            this.buttonEditarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditarProduto.UseVisualStyleBackColor = true;
            this.buttonEditarProduto.Click += new System.EventHandler(this.buttonEditarProduto_Click);
            // 
            // buttonAdicionaProduto
            // 
            this.buttonAdicionaProduto.Image = global::HSA_Estoque.Properties.Resources.Adiciona16x16;
            this.buttonAdicionaProduto.Location = new System.Drawing.Point(15, 477);
            this.buttonAdicionaProduto.Name = "buttonAdicionaProduto";
            this.buttonAdicionaProduto.Size = new System.Drawing.Size(100, 32);
            this.buttonAdicionaProduto.TabIndex = 12;
            this.buttonAdicionaProduto.Text = "Adicionar";
            this.buttonAdicionaProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdicionaProduto.UseVisualStyleBackColor = true;
            this.buttonAdicionaProduto.Click += new System.EventHandler(this.buttonAdicionaProduto_Click);
            // 
            // buttonAdministrarTipo
            // 
            this.buttonAdministrarTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdministrarTipo.Location = new System.Drawing.Point(366, 208);
            this.buttonAdministrarTipo.Name = "buttonAdministrarTipo";
            this.buttonAdministrarTipo.Size = new System.Drawing.Size(100, 26);
            this.buttonAdministrarTipo.TabIndex = 26;
            this.buttonAdministrarTipo.Text = "Administrar";
            this.buttonAdministrarTipo.UseVisualStyleBackColor = true;
            this.buttonAdministrarTipo.Click += new System.EventHandler(this.buttonAdministrarTipo_Click);
            // 
            // buttonAdministrarUnidade
            // 
            this.buttonAdministrarUnidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdministrarUnidade.Location = new System.Drawing.Point(366, 240);
            this.buttonAdministrarUnidade.Name = "buttonAdministrarUnidade";
            this.buttonAdministrarUnidade.Size = new System.Drawing.Size(100, 26);
            this.buttonAdministrarUnidade.TabIndex = 27;
            this.buttonAdministrarUnidade.Text = "Administrar";
            this.buttonAdministrarUnidade.UseVisualStyleBackColor = true;
            this.buttonAdministrarUnidade.Click += new System.EventHandler(this.buttonAdministrarUnidade_Click);
            // 
            // textBoxObs
            // 
            this.textBoxObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxObs.Location = new System.Drawing.Point(142, 400);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(430, 71);
            this.textBoxObs.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Obs";
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 521);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonAdministrarUnidade);
            this.Controls.Add(this.buttonAdministrarTipo);
            this.Controls.Add(this.buttonEditarProduto);
            this.Controls.Add(this.buttonAdicionaProduto);
            this.Controls.Add(this.textBoxDataInclusão);
            this.Controls.Add(this.labelDataInclusao);
            this.Controls.Add(this.textBoxInseridoPor);
            this.Controls.Add(this.labelInseridoPor);
            this.Controls.Add(this.textBoxProdutoCaixa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxProdutoLocalizacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxUnidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxProdutoLeadTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxProdutoQuantidadeMaxima);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProdutoQuantidadeMinima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProdutoQuantidadeTotal);
            this.Controls.Add(this.labelQtdInicial);
            this.Controls.Add(this.textBoxProdutoDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProdutoId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduto";
            this.Text = "HSA Estoque - Inclusão de produto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProdutoId;
        private System.Windows.Forms.TextBox textBoxProdutoDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProdutoQuantidadeTotal;
        private System.Windows.Forms.Label labelQtdInicial;
        private System.Windows.Forms.TextBox textBoxProdutoQuantidadeMinima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProdutoQuantidadeMaxima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProdutoLeadTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxUnidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProdutoLocalizacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxProdutoCaixa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxInseridoPor;
        private System.Windows.Forms.Label labelInseridoPor;
        private System.Windows.Forms.TextBox textBoxDataInclusão;
        private System.Windows.Forms.Label labelDataInclusao;
        private System.Windows.Forms.Button buttonAdicionaProduto;
        private System.Windows.Forms.Button buttonEditarProduto;
        private System.Windows.Forms.Button buttonAdministrarTipo;
        private System.Windows.Forms.Button buttonAdministrarUnidade;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label11;
    }
}