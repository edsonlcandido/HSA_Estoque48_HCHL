namespace HSA_Estoque
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEditarProduto = new System.Windows.Forms.Button();
            this.buttonCadastrarNovoProduto = new System.Windows.Forms.Button();
            this.buttonSaidaEstoque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEntradaEstoque = new System.Windows.Forms.Button();
            this.tableLayoutPanelItensOK = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProdutosOK = new System.Windows.Forms.Label();
            this.tableLayoutPanelItensAcabando = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProdutosAcabando = new System.Windows.Forms.Label();
            this.tableLayoutPanelSemMaterial = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSemMaterial = new System.Windows.Forms.Label();
            this.tableLayoutPanelTodosProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPesquisaPorDescricao = new System.Windows.Forms.Button();
            this.textBoxPesquisaPordescricao = new System.Windows.Forms.TextBox();
            this.buttonPesquisaPorCodigo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPesquisaPorCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeMaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelItensOK.SuspendLayout();
            this.tableLayoutPanelItensAcabando.SuspendLayout();
            this.tableLayoutPanelSemMaterial.SuspendLayout();
            this.tableLayoutPanelTodosProdutos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposToolStripMenuItem,
            this.unidadesToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // tiposToolStripMenuItem
            // 
            this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
            this.tiposToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.tiposToolStripMenuItem.Text = "Tipos";
            this.tiposToolStripMenuItem.Click += new System.EventHandler(this.tiposToolStripMenuItem_Click);
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.unidadesToolStripMenuItem.Text = "Unidades";
            this.unidadesToolStripMenuItem.Click += new System.EventHandler(this.unidadesToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçãoToolStripMenuItem,
            this.resumoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // resumoToolStripMenuItem
            // 
            this.resumoToolStripMenuItem.Name = "resumoToolStripMenuItem";
            this.resumoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.resumoToolStripMenuItem.Text = "Resumo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.buttonEditarProduto);
            this.panel1.Controls.Add(this.buttonCadastrarNovoProduto);
            this.panel1.Controls.Add(this.buttonSaidaEstoque);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonEntradaEstoque);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 699);
            this.panel1.TabIndex = 1;
            // 
            // buttonEditarProduto
            // 
            this.buttonEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarProduto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarProduto.Image = global::HSA_Estoque.Properties.Resources.EditarProduto32x32;
            this.buttonEditarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarProduto.Location = new System.Drawing.Point(5, 355);
            this.buttonEditarProduto.Name = "buttonEditarProduto";
            this.buttonEditarProduto.Size = new System.Drawing.Size(241, 53);
            this.buttonEditarProduto.TabIndex = 4;
            this.buttonEditarProduto.Text = "Editar produto";
            this.buttonEditarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditarProduto.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarNovoProduto
            // 
            this.buttonCadastrarNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrarNovoProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarNovoProduto.Image = global::HSA_Estoque.Properties.Resources.CadastrarProduto32x32;
            this.buttonCadastrarNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrarNovoProduto.Location = new System.Drawing.Point(5, 273);
            this.buttonCadastrarNovoProduto.Name = "buttonCadastrarNovoProduto";
            this.buttonCadastrarNovoProduto.Size = new System.Drawing.Size(241, 53);
            this.buttonCadastrarNovoProduto.TabIndex = 3;
            this.buttonCadastrarNovoProduto.Text = "Cadastrar novo produto";
            this.buttonCadastrarNovoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrarNovoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastrarNovoProduto.UseVisualStyleBackColor = true;
            this.buttonCadastrarNovoProduto.Click += new System.EventHandler(this.buttonCadastrarNovoProduto_Click);
            // 
            // buttonSaidaEstoque
            // 
            this.buttonSaidaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaidaEstoque.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaidaEstoque.Image = global::HSA_Estoque.Properties.Resources.Saida32x32;
            this.buttonSaidaEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaidaEstoque.Location = new System.Drawing.Point(5, 191);
            this.buttonSaidaEstoque.Name = "buttonSaidaEstoque";
            this.buttonSaidaEstoque.Size = new System.Drawing.Size(241, 53);
            this.buttonSaidaEstoque.TabIndex = 2;
            this.buttonSaidaEstoque.Text = "Saída";
            this.buttonSaidaEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaidaEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaidaEstoque.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(244, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "Controle de estoque";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEntradaEstoque
            // 
            this.buttonEntradaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntradaEstoque.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntradaEstoque.Image = global::HSA_Estoque.Properties.Resources.Entrada32x32;
            this.buttonEntradaEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEntradaEstoque.Location = new System.Drawing.Point(5, 109);
            this.buttonEntradaEstoque.Name = "buttonEntradaEstoque";
            this.buttonEntradaEstoque.Size = new System.Drawing.Size(241, 53);
            this.buttonEntradaEstoque.TabIndex = 0;
            this.buttonEntradaEstoque.Text = "Entrada";
            this.buttonEntradaEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEntradaEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEntradaEstoque.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelItensOK
            // 
            this.tableLayoutPanelItensOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.tableLayoutPanelItensOK.ColumnCount = 1;
            this.tableLayoutPanelItensOK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItensOK.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanelItensOK.Controls.Add(this.labelProdutosOK, 0, 1);
            this.tableLayoutPanelItensOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanelItensOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.tableLayoutPanelItensOK.Location = new System.Drawing.Point(265, 42);
            this.tableLayoutPanelItensOK.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanelItensOK.Name = "tableLayoutPanelItensOK";
            this.tableLayoutPanelItensOK.RowCount = 2;
            this.tableLayoutPanelItensOK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelItensOK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItensOK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelItensOK.Size = new System.Drawing.Size(280, 120);
            this.tableLayoutPanelItensOK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produtos OK";
            // 
            // labelProdutosOK
            // 
            this.labelProdutosOK.AutoSize = true;
            this.labelProdutosOK.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutosOK.Location = new System.Drawing.Point(3, 50);
            this.labelProdutosOK.Name = "labelProdutosOK";
            this.labelProdutosOK.Size = new System.Drawing.Size(208, 44);
            this.labelProdutosOK.TabIndex = 1;
            this.labelProdutosOK.Text = "{xxx} itens estão com a quantidades ok";
            // 
            // tableLayoutPanelItensAcabando
            // 
            this.tableLayoutPanelItensAcabando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.tableLayoutPanelItensAcabando.ColumnCount = 1;
            this.tableLayoutPanelItensAcabando.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItensAcabando.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelItensAcabando.Controls.Add(this.labelProdutosAcabando, 0, 1);
            this.tableLayoutPanelItensAcabando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanelItensAcabando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(72)))), ((int)(((byte)(61)))));
            this.tableLayoutPanelItensAcabando.Location = new System.Drawing.Point(569, 42);
            this.tableLayoutPanelItensAcabando.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanelItensAcabando.Name = "tableLayoutPanelItensAcabando";
            this.tableLayoutPanelItensAcabando.RowCount = 2;
            this.tableLayoutPanelItensAcabando.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelItensAcabando.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItensAcabando.Size = new System.Drawing.Size(280, 120);
            this.tableLayoutPanelItensAcabando.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Produtos acabando";
            // 
            // labelProdutosAcabando
            // 
            this.labelProdutosAcabando.AutoSize = true;
            this.labelProdutosAcabando.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutosAcabando.Location = new System.Drawing.Point(3, 50);
            this.labelProdutosAcabando.Name = "labelProdutosAcabando";
            this.labelProdutosAcabando.Size = new System.Drawing.Size(268, 44);
            this.labelProdutosAcabando.TabIndex = 1;
            this.labelProdutosAcabando.Text = "{xxx} itens estão com a quantidades inferior ao minimo";
            // 
            // tableLayoutPanelSemMaterial
            // 
            this.tableLayoutPanelSemMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(215)))), ((int)(((byte)(218)))));
            this.tableLayoutPanelSemMaterial.ColumnCount = 1;
            this.tableLayoutPanelSemMaterial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSemMaterial.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanelSemMaterial.Controls.Add(this.labelSemMaterial, 0, 1);
            this.tableLayoutPanelSemMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanelSemMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.tableLayoutPanelSemMaterial.Location = new System.Drawing.Point(265, 186);
            this.tableLayoutPanelSemMaterial.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanelSemMaterial.Name = "tableLayoutPanelSemMaterial";
            this.tableLayoutPanelSemMaterial.RowCount = 2;
            this.tableLayoutPanelSemMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelSemMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSemMaterial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSemMaterial.Size = new System.Drawing.Size(280, 120);
            this.tableLayoutPanelSemMaterial.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sem material";
            // 
            // labelSemMaterial
            // 
            this.labelSemMaterial.AutoSize = true;
            this.labelSemMaterial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemMaterial.Location = new System.Drawing.Point(3, 50);
            this.labelSemMaterial.Name = "labelSemMaterial";
            this.labelSemMaterial.Size = new System.Drawing.Size(262, 22);
            this.labelSemMaterial.TabIndex = 1;
            this.labelSemMaterial.Text = "{xxx} itens estão sem estoque";
            // 
            // tableLayoutPanelTodosProdutos
            // 
            this.tableLayoutPanelTodosProdutos.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelTodosProdutos.ColumnCount = 1;
            this.tableLayoutPanelTodosProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTodosProdutos.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanelTodosProdutos.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanelTodosProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanelTodosProdutos.Location = new System.Drawing.Point(569, 186);
            this.tableLayoutPanelTodosProdutos.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanelTodosProdutos.Name = "tableLayoutPanelTodosProdutos";
            this.tableLayoutPanelTodosProdutos.RowCount = 2;
            this.tableLayoutPanelTodosProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelTodosProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTodosProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTodosProdutos.Size = new System.Drawing.Size(280, 120);
            this.tableLayoutPanelTodosProdutos.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Todos os produtos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 44);
            this.label9.TabIndex = 1;
            this.label9.Text = "Exibir todos os itens cadastrados no estoque";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPesquisaPorDescricao);
            this.groupBox1.Controls.Add(this.textBoxPesquisaPordescricao);
            this.groupBox1.Controls.Add(this.buttonPesquisaPorCodigo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxPesquisaPorCodigo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(265, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa produto";
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
            // textBoxPesquisaPordescricao
            // 
            this.textBoxPesquisaPordescricao.Location = new System.Drawing.Point(93, 69);
            this.textBoxPesquisaPordescricao.Name = "textBoxPesquisaPordescricao";
            this.textBoxPesquisaPordescricao.Size = new System.Drawing.Size(262, 26);
            this.textBoxPesquisaPordescricao.TabIndex = 8;
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
            this.localizacaoDataGridViewTextBoxColumn,
            this.caixaDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.quantidadeTotalDataGridViewTextBoxColumn,
            this.quantidadeMinimaDataGridViewTextBoxColumn,
            this.quantidadeMaximaDataGridViewTextBoxColumn,
            this.leadTimeDataGridViewTextBoxColumn});
            this.dataGridViewProdutos.DataSource = this.produtoBindingSource;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(256, 444);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(745, 280);
            this.dataGridViewProdutos.TabIndex = 7;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(HSA_Estoque.Model.Produto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 350;
            // 
            // localizacaoDataGridViewTextBoxColumn
            // 
            this.localizacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.localizacaoDataGridViewTextBoxColumn.DataPropertyName = "localizacao";
            this.localizacaoDataGridViewTextBoxColumn.HeaderText = "Localização";
            this.localizacaoDataGridViewTextBoxColumn.Name = "localizacaoDataGridViewTextBoxColumn";
            this.localizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.localizacaoDataGridViewTextBoxColumn.Width = 117;
            // 
            // caixaDataGridViewTextBoxColumn
            // 
            this.caixaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.caixaDataGridViewTextBoxColumn.DataPropertyName = "caixa";
            this.caixaDataGridViewTextBoxColumn.HeaderText = "Caixa";
            this.caixaDataGridViewTextBoxColumn.Name = "caixaDataGridViewTextBoxColumn";
            this.caixaDataGridViewTextBoxColumn.ReadOnly = true;
            this.caixaDataGridViewTextBoxColumn.Width = 74;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "UN";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Width = 55;
            // 
            // quantidadeTotalDataGridViewTextBoxColumn
            // 
            this.quantidadeTotalDataGridViewTextBoxColumn.DataPropertyName = "quantidadeTotal";
            this.quantidadeTotalDataGridViewTextBoxColumn.HeaderText = "Qtd. atual";
            this.quantidadeTotalDataGridViewTextBoxColumn.Name = "quantidadeTotalDataGridViewTextBoxColumn";
            this.quantidadeTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeTotalDataGridViewTextBoxColumn.Width = 75;
            // 
            // quantidadeMinimaDataGridViewTextBoxColumn
            // 
            this.quantidadeMinimaDataGridViewTextBoxColumn.DataPropertyName = "quantidadeMinima";
            this.quantidadeMinimaDataGridViewTextBoxColumn.HeaderText = "Qtd. mín.";
            this.quantidadeMinimaDataGridViewTextBoxColumn.Name = "quantidadeMinimaDataGridViewTextBoxColumn";
            this.quantidadeMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeMinimaDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantidadeMaximaDataGridViewTextBoxColumn
            // 
            this.quantidadeMaximaDataGridViewTextBoxColumn.DataPropertyName = "quantidadeMaxima";
            this.quantidadeMaximaDataGridViewTextBoxColumn.HeaderText = "Qtd. máx.";
            this.quantidadeMaximaDataGridViewTextBoxColumn.Name = "quantidadeMaximaDataGridViewTextBoxColumn";
            this.quantidadeMaximaDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeMaximaDataGridViewTextBoxColumn.Width = 75;
            // 
            // leadTimeDataGridViewTextBoxColumn
            // 
            this.leadTimeDataGridViewTextBoxColumn.DataPropertyName = "leadTime";
            this.leadTimeDataGridViewTextBoxColumn.HeaderText = "Lead time";
            this.leadTimeDataGridViewTextBoxColumn.Name = "leadTimeDataGridViewTextBoxColumn";
            this.leadTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.leadTimeDataGridViewTextBoxColumn.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanelTodosProdutos);
            this.Controls.Add(this.tableLayoutPanelSemMaterial);
            this.Controls.Add(this.tableLayoutPanelItensAcabando);
            this.Controls.Add(this.tableLayoutPanelItensOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(880, 660);
            this.Name = "FormMain";
            this.Text = "HSA Estoque";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelItensOK.ResumeLayout(false);
            this.tableLayoutPanelItensOK.PerformLayout();
            this.tableLayoutPanelItensAcabando.ResumeLayout(false);
            this.tableLayoutPanelItensAcabando.PerformLayout();
            this.tableLayoutPanelSemMaterial.ResumeLayout(false);
            this.tableLayoutPanelSemMaterial.PerformLayout();
            this.tableLayoutPanelTodosProdutos.ResumeLayout(false);
            this.tableLayoutPanelTodosProdutos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEntradaEstoque;
        private System.Windows.Forms.Button buttonSaidaEstoque;
        private System.Windows.Forms.Button buttonEditarProduto;
        private System.Windows.Forms.Button buttonCadastrarNovoProduto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelItensOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProdutosOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelItensAcabando;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProdutosAcabando;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSemMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSemMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTodosProdutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPesquisaPorCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonPesquisaPorDescricao;
        private System.Windows.Forms.TextBox textBoxPesquisaPordescricao;
        private System.Windows.Forms.Button buttonPesquisaPorCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeMinimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeMaximaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource;
    }
}

