namespace Deposito_TG
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.tbcpedido = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNovoAluguel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtvalortotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadicionarialuguel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboatendente = new System.Windows.Forms.ComboBox();
            this.txtcodigopedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtobservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvpedido = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcpedido.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcpedido
            // 
            this.tbcpedido.Controls.Add(this.tabPage2);
            this.tbcpedido.Controls.Add(this.tabPage1);
            this.tbcpedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcpedido.Location = new System.Drawing.Point(0, 0);
            this.tbcpedido.Margin = new System.Windows.Forms.Padding(6);
            this.tbcpedido.Name = "tbcpedido";
            this.tbcpedido.SelectedIndex = 0;
            this.tbcpedido.Size = new System.Drawing.Size(1354, 709);
            this.tbcpedido.TabIndex = 4;
            this.tbcpedido.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcpedido_Selected);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnNovoAluguel);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.txtdesconto);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtvalortotal);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnadicionarialuguel);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1346, 672);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Realizar Pedido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1144, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "R$";
            // 
            // btnNovoAluguel
            // 
            this.btnNovoAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNovoAluguel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovoAluguel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNovoAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAluguel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnNovoAluguel.Location = new System.Drawing.Point(1045, 161);
            this.btnNovoAluguel.Name = "btnNovoAluguel";
            this.btnNovoAluguel.Size = new System.Drawing.Size(241, 53);
            this.btnNovoAluguel.TabIndex = 6;
            this.btnNovoAluguel.Text = "Novo Aluguel";
            this.btnNovoAluguel.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dgvItens);
            this.groupBox2.Controls.Add(this.txttotalproduto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtvaloruniproduto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboproduto);
            this.groupBox2.Controls.Add(this.txtquantidadeproduto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtcodigoproduto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnexcluir);
            this.groupBox2.Controls.Add(this.btnincluir);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1334, 444);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(1175, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 120);
            this.button2.TabIndex = 4;
            this.button2.Text = "CONCLUIR VENDA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7,
            this.Column9});
            this.dgvItens.Location = new System.Drawing.Point(13, 90);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(6);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(1140, 336);
            this.dgvItens.TabIndex = 30;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idpro";
            this.Column5.HeaderText = "Código";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "descricao";
            this.Column6.HeaderText = "Produto";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "precounitario";
            this.Column8.HeaderText = "Valor Unitário";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "quantidade";
            this.Column7.HeaderText = "Quantidade";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "total";
            this.Column9.HeaderText = "Total Item";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // txttotalproduto
            // 
            this.txttotalproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalproduto.Location = new System.Drawing.Point(1013, 49);
            this.txttotalproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txttotalproduto.Name = "txttotalproduto";
            this.txttotalproduto.ReadOnly = true;
            this.txttotalproduto.Size = new System.Drawing.Size(140, 29);
            this.txttotalproduto.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1009, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total Item:";
            // 
            // txtvaloruniproduto
            // 
            this.txtvaloruniproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvaloruniproduto.Location = new System.Drawing.Point(848, 49);
            this.txtvaloruniproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtvaloruniproduto.Name = "txtvaloruniproduto";
            this.txtvaloruniproduto.ReadOnly = true;
            this.txtvaloruniproduto.Size = new System.Drawing.Size(122, 29);
            this.txtvaloruniproduto.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(828, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Valor Unitário:";
            // 
            // cboproduto
            // 
            this.cboproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboproduto.FormattingEnabled = true;
            this.cboproduto.Location = new System.Drawing.Point(166, 47);
            this.cboproduto.Margin = new System.Windows.Forms.Padding(6);
            this.cboproduto.Name = "cboproduto";
            this.cboproduto.Size = new System.Drawing.Size(512, 32);
            this.cboproduto.TabIndex = 0;
            this.cboproduto.SelectedIndexChanged += new System.EventHandler(this.cboproduto_SelectedIndexChanged);
            // 
            // txtquantidadeproduto
            // 
            this.txtquantidadeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidadeproduto.Location = new System.Drawing.Point(690, 49);
            this.txtquantidadeproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtquantidadeproduto.Name = "txtquantidadeproduto";
            this.txtquantidadeproduto.Size = new System.Drawing.Size(120, 29);
            this.txtquantidadeproduto.TabIndex = 1;
            this.txtquantidadeproduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtquantidadeproduto_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(686, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Produto:";
            // 
            // txtcodigoproduto
            // 
            this.txtcodigoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoproduto.Location = new System.Drawing.Point(48, 48);
            this.txtcodigoproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtcodigoproduto.Name = "txtcodigoproduto";
            this.txtcodigoproduto.Size = new System.Drawing.Size(106, 31);
            this.txtcodigoproduto.TabIndex = 21;
            this.txtcodigoproduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcodigoproduto_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Código:";
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnexcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(1175, 104);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(6);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(121, 40);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "Excluir item";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click_1);
            // 
            // btnincluir
            // 
            this.btnincluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnincluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnincluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnincluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnincluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.Location = new System.Drawing.Point(1175, 37);
            this.btnincluir.Margin = new System.Windows.Forms.Padding(6);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(121, 41);
            this.btnincluir.TabIndex = 2;
            this.btnincluir.Text = "Incluir item";
            this.btnincluir.UseVisualStyleBackColor = false;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(812, 52);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "R$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(972, 52);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 24);
            this.label14.TabIndex = 32;
            this.label14.Text = "R$";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(1191, 112);
            this.txtdesconto.Margin = new System.Windows.Forms.Padding(6);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(143, 29);
            this.txtdesconto.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(958, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Desconto";
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtvalortotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalortotal.ForeColor = System.Drawing.Color.Red;
            this.txtvalortotal.Location = new System.Drawing.Point(962, 35);
            this.txtvalortotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtvalortotal.Multiline = true;
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.ReadOnly = true;
            this.txtvalortotal.Size = new System.Drawing.Size(372, 73);
            this.txtvalortotal.TabIndex = 20;
            this.txtvalortotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(957, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "VALOR TOTAL:";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnNovoCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbocliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboatendente);
            this.groupBox1.Controls.Add(this.txtcodigopedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtobservacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(879, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpar.Location = new System.Drawing.Point(462, 29);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 30);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNovoCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnNovoCliente.Location = new System.Drawing.Point(770, 64);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(100, 65);
            this.btnNovoCliente.TabIndex = 25;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observação:";
            // 
            // cbocliente
            // 
            this.cbocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(167, 103);
            this.cbocliente.Margin = new System.Windows.Forms.Padding(6);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(593, 26);
            this.cbocliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente:";
            // 
            // cboatendente
            // 
            this.cboatendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboatendente.FormattingEnabled = true;
            this.cboatendente.Location = new System.Drawing.Point(167, 65);
            this.cboatendente.Margin = new System.Windows.Forms.Padding(6);
            this.cboatendente.Name = "cboatendente";
            this.cboatendente.Size = new System.Drawing.Size(593, 26);
            this.cboatendente.TabIndex = 1;
            // 
            // txtcodigopedido
            // 
            this.txtcodigopedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigopedido.Location = new System.Drawing.Point(167, 32);
            this.txtcodigopedido.Margin = new System.Windows.Forms.Padding(6);
            this.txtcodigopedido.Name = "txtcodigopedido";
            this.txtcodigopedido.ReadOnly = true;
            this.txtcodigopedido.Size = new System.Drawing.Size(214, 24);
            this.txtcodigopedido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da venda:";
            // 
            // txtobservacao
            // 
            this.txtobservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacao.Location = new System.Drawing.Point(167, 141);
            this.txtobservacao.Margin = new System.Windows.Forms.Padding(6);
            this.txtobservacao.Multiline = true;
            this.txtobservacao.Name = "txtobservacao";
            this.txtobservacao.Size = new System.Drawing.Size(593, 49);
            this.txtobservacao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvpedido);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1346, 672);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvpedido
            // 
            this.dgvpedido.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.dgvpedido.AllowUserToAddRows = false;
            this.dgvpedido.AllowUserToDeleteRows = false;
            this.dgvpedido.AllowUserToResizeColumns = false;
            this.dgvpedido.AllowUserToResizeRows = false;
            this.dgvpedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dgvpedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpedido.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvpedido.Location = new System.Drawing.Point(6, 6);
            this.dgvpedido.Margin = new System.Windows.Forms.Padding(6);
            this.dgvpedido.MultiSelect = false;
            this.dgvpedido.Name = "dgvpedido";
            this.dgvpedido.ReadOnly = true;
            this.dgvpedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpedido.Size = new System.Drawing.Size(1334, 660);
            this.dgvpedido.TabIndex = 0;
            this.dgvpedido.DoubleClick += new System.EventHandler(this.dgvpedido_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idped";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idobs";
            this.Column1.HeaderText = "Observação";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "vltotal";
            this.Column2.HeaderText = "Valor Total";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nome";
            this.Column4.HeaderText = "Cliente";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nome";
            this.Column3.HeaderText = "Atendente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 709);
            this.Controls.Add(this.tbcpedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedido_KeyDown);
            this.tbcpedido.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcpedido;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvpedido;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtobservacao;
        private System.Windows.Forms.TextBox txtcodigopedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbocliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboatendente;
        private System.Windows.Forms.Button btnadicionarialuguel;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtvalortotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItens;
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
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnNovoAluguel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}