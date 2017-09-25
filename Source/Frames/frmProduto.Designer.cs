namespace Deposito_TG
{
    partial class frmProduto
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
            this.tbcProduto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.txtlimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbovendedor = new System.Windows.Forms.ComboBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcProduto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcProduto
            // 
            this.tbcProduto.Controls.Add(this.tabPage1);
            this.tbcProduto.Controls.Add(this.tabPage2);
            this.tbcProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcProduto.Location = new System.Drawing.Point(0, 0);
            this.tbcProduto.Name = "tbcProduto";
            this.tbcProduto.SelectedIndex = 0;
            this.tbcProduto.Size = new System.Drawing.Size(484, 461);
            this.tbcProduto.TabIndex = 4;
            this.tbcProduto.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcProduto_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvproduto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvproduto
            // 
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvproduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproduto.Location = new System.Drawing.Point(3, 3);
            this.dgvproduto.MultiSelect = false;
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproduto.Size = new System.Drawing.Size(470, 429);
            this.dgvproduto.TabIndex = 0;
            this.dgvproduto.DoubleClick += new System.EventHandler(this.dgvproduto_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idpro";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "descricao";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "preco";
            this.Column1.HeaderText = "Preco";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "Vendedor";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "empresa";
            this.Column3.HeaderText = "Empresa";
            this.Column3.Name = "Column3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cboempresa);
            this.tabPage2.Controls.Add(this.txtlimpar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbovendedor);
            this.tabPage2.Controls.Add(this.txtpreco);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtdescricao);
            this.tabPage2.Controls.Add(this.txtcodigo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Empresa:";
            // 
            // cboempresa
            // 
            this.cboempresa.Enabled = false;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(98, 153);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(307, 21);
            this.cboempresa.TabIndex = 4;
            // 
            // txtlimpar
            // 
            this.txtlimpar.Location = new System.Drawing.Point(393, 35);
            this.txtlimpar.Name = "txtlimpar";
            this.txtlimpar.Size = new System.Drawing.Size(75, 23);
            this.txtlimpar.TabIndex = 9;
            this.txtlimpar.Text = "Limpar";
            this.txtlimpar.UseVisualStyleBackColor = true;
            this.txtlimpar.Click += new System.EventHandler(this.txtlimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vendedor:";
            // 
            // cbovendedor
            // 
            this.cbovendedor.FormattingEnabled = true;
            this.cbovendedor.Location = new System.Drawing.Point(98, 126);
            this.cbovendedor.Name = "cbovendedor";
            this.cbovendedor.Size = new System.Drawing.Size(307, 21);
            this.cbovendedor.TabIndex = 3;
            this.cbovendedor.Leave += new System.EventHandler(this.cbovendedor_Leave);
            // 
            // txtpreco
            // 
            this.txtpreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(98, 95);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(127, 21);
            this.txtpreco.TabIndex = 2;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(393, 193);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(308, 193);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(218, 193);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 6;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(130, 193);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 5;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(98, 68);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(370, 21);
            this.txtdescricao.TabIndex = 1;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(98, 39);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(127, 21);
            this.txtcodigo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tbcProduto);
            this.KeyPreview = true;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduto_KeyDown);
            this.tbcProduto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcProduto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbovendedor;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Button txtlimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboempresa;
    }
}