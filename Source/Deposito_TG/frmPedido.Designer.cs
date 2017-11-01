namespace Deposito_TG
{
    partial class frmPedido
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
            this.tbcpedido = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvpedido = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnadicionarialuguel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttotalproduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtvaloruniproduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboproduto = new System.Windows.Forms.ComboBox();
            this.txtquantidadeproduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigoproduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboatendente = new System.Windows.Forms.ComboBox();
            this.txtcodigopedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtobservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtvalortotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnovocliente = new System.Windows.Forms.Button();
            this.tbcpedido.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcpedido
            // 
            this.tbcpedido.Controls.Add(this.tabPage1);
            this.tbcpedido.Controls.Add(this.tabPage2);
            this.tbcpedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcpedido.Location = new System.Drawing.Point(0, 0);
            this.tbcpedido.Margin = new System.Windows.Forms.Padding(6);
            this.tbcpedido.Name = "tbcpedido";
            this.tbcpedido.SelectedIndex = 0;
            this.tbcpedido.Size = new System.Drawing.Size(1354, 733);
            this.tbcpedido.TabIndex = 4;
            this.tbcpedido.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcpedido_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvpedido);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1346, 696);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvpedido
            // 
            this.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dgvpedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpedido.Location = new System.Drawing.Point(6, 6);
            this.dgvpedido.Margin = new System.Windows.Forms.Padding(6);
            this.dgvpedido.MultiSelect = false;
            this.dgvpedido.Name = "dgvpedido";
            this.dgvpedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpedido.Size = new System.Drawing.Size(1334, 684);
            this.dgvpedido.TabIndex = 0;
            this.dgvpedido.DoubleClick += new System.EventHandler(this.dgvpedido_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idped";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idobs";
            this.Column1.HeaderText = "Observação";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "vltotal";
            this.Column2.HeaderText = "Valor Total";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nome";
            this.Column4.HeaderText = "Cliente";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nome";
            this.Column3.HeaderText = "Atendente";
            this.Column3.Name = "Column3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtdesconto);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtvalortotal);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnadicionarialuguel);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.txttotalproduto);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtvaloruniproduto);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cboproduto);
            this.tabPage2.Controls.Add(this.txtquantidadeproduto);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtcodigoproduto);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1346, 696);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnadicionarialuguel
            // 
            this.btnadicionarialuguel.Location = new System.Drawing.Point(480, 816);
            this.btnadicionarialuguel.Margin = new System.Windows.Forms.Padding(6);
            this.btnadicionarialuguel.Name = "btnadicionarialuguel";
            this.btnadicionarialuguel.Size = new System.Drawing.Size(227, 65);
            this.btnadicionarialuguel.TabIndex = 17;
            this.btnadicionarialuguel.Text = "Adicionar Aluguel";
            this.btnadicionarialuguel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(14, 384);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 301);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idpro";
            this.Column5.HeaderText = "Código";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nome";
            this.Column6.HeaderText = "Produto";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "qtde";
            this.Column7.HeaderText = "Quantidade";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "preco";
            this.Column8.HeaderText = "Vl Unitario";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "total";
            this.Column9.HeaderText = "Total";
            this.Column9.Name = "Column9";
            // 
            // txttotalproduto
            // 
            this.txttotalproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalproduto.Location = new System.Drawing.Point(1113, 343);
            this.txttotalproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txttotalproduto.Name = "txttotalproduto";
            this.txttotalproduto.Size = new System.Drawing.Size(153, 29);
            this.txttotalproduto.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1109, 308);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total item:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtvaloruniproduto
            // 
            this.txtvaloruniproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvaloruniproduto.Location = new System.Drawing.Point(938, 343);
            this.txtvaloruniproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtvaloruniproduto.Name = "txtvaloruniproduto";
            this.txtvaloruniproduto.Size = new System.Drawing.Size(136, 29);
            this.txtvaloruniproduto.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(934, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Vl Unit:";
            // 
            // cboproduto
            // 
            this.cboproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboproduto.FormattingEnabled = true;
            this.cboproduto.Location = new System.Drawing.Point(197, 340);
            this.cboproduto.Margin = new System.Windows.Forms.Padding(6);
            this.cboproduto.Name = "cboproduto";
            this.cboproduto.Size = new System.Drawing.Size(521, 32);
            this.cboproduto.TabIndex = 7;
            // 
            // txtquantidadeproduto
            // 
            this.txtquantidadeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidadeproduto.Location = new System.Drawing.Point(755, 343);
            this.txtquantidadeproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtquantidadeproduto.Name = "txtquantidadeproduto";
            this.txtquantidadeproduto.Size = new System.Drawing.Size(142, 29);
            this.txtquantidadeproduto.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(751, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Qtde:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Produto:";
            // 
            // txtcodigoproduto
            // 
            this.txtcodigoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoproduto.Location = new System.Drawing.Point(16, 343);
            this.txtcodigoproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtcodigoproduto.Name = "txtcodigoproduto";
            this.txtcodigoproduto.Size = new System.Drawing.Size(149, 29);
            this.txtcodigoproduto.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnovocliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbocliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboatendente);
            this.groupBox1.Controls.Add(this.txtcodigopedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtobservacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(938, 277);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observação:";
            // 
            // cbocliente
            // 
            this.cbocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(182, 135);
            this.cbocliente.Margin = new System.Windows.Forms.Padding(6);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(609, 32);
            this.cbocliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente:";
            // 
            // cboatendente
            // 
            this.cboatendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboatendente.FormattingEnabled = true;
            this.cboatendente.Location = new System.Drawing.Point(182, 85);
            this.cboatendente.Margin = new System.Windows.Forms.Padding(6);
            this.cboatendente.Name = "cboatendente";
            this.cboatendente.Size = new System.Drawing.Size(609, 32);
            this.cboatendente.TabIndex = 1;
            // 
            // txtcodigopedido
            // 
            this.txtcodigopedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigopedido.Location = new System.Drawing.Point(182, 35);
            this.txtcodigopedido.Margin = new System.Windows.Forms.Padding(6);
            this.txtcodigopedido.Name = "txtcodigopedido";
            this.txtcodigopedido.Size = new System.Drawing.Size(230, 29);
            this.txtcodigopedido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtobservacao
            // 
            this.txtobservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacao.Location = new System.Drawing.Point(182, 185);
            this.txtobservacao.Margin = new System.Windows.Forms.Padding(6);
            this.txtobservacao.Multiline = true;
            this.txtobservacao.Name = "txtobservacao";
            this.txtobservacao.Size = new System.Drawing.Size(609, 74);
            this.txtobservacao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atendente:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(1195, 746);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(6);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(196, 135);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Finalizar Pedido";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(1183, 604);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(6);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(138, 42);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(1183, 518);
            this.btngravar.Margin = new System.Windows.Forms.Padding(6);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(138, 42);
            this.btngravar.TabIndex = 4;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(1183, 432);
            this.btnincluir.Margin = new System.Windows.Forms.Padding(6);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(138, 42);
            this.btnincluir.TabIndex = 3;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtdesconto
            // 
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(1024, 205);
            this.txtdesconto.Margin = new System.Windows.Forms.Padding(6);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(230, 29);
            this.txtdesconto.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1088, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Desconto:";
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalortotal.Location = new System.Drawing.Point(965, 84);
            this.txtvalortotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.Size = new System.Drawing.Size(338, 47);
            this.txtvalortotal.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1042, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "VALOR TOTAL:";
            // 
            // btnnovocliente
            // 
            this.btnnovocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovocliente.Location = new System.Drawing.Point(816, 134);
            this.btnnovocliente.Name = "btnnovocliente";
            this.btnnovocliente.Size = new System.Drawing.Size(113, 33);
            this.btnnovocliente.TabIndex = 5;
            this.btnnovocliente.Text = "Novo Cliente";
            this.btnnovocliente.UseVisualStyleBackColor = true;
            this.btnnovocliente.Click += new System.EventHandler(this.btnnovocliente_Click);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.tbcpedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedido_KeyDown);
            this.tbcpedido.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcpedido;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvpedido;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtobservacao;
        private System.Windows.Forms.TextBox txtcodigopedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttotalproduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtvaloruniproduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboproduto;
        private System.Windows.Forms.TextBox txtquantidadeproduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigoproduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbocliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboatendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnadicionarialuguel;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtvalortotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnovocliente;
    }
}