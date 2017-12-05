namespace Deposito_TG
{
    partial class FrmVendedor
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
            this.tbcvendedores = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvvendedores = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msktelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskcelular = new System.Windows.Forms.MaskedTextBox();
            this.tbcvendedores.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendedores)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcvendedores
            // 
            this.tbcvendedores.Controls.Add(this.tabPage1);
            this.tbcvendedores.Controls.Add(this.tabPage2);
            this.tbcvendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcvendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcvendedores.Location = new System.Drawing.Point(0, 0);
            this.tbcvendedores.Name = "tbcvendedores";
            this.tbcvendedores.SelectedIndex = 0;
            this.tbcvendedores.Size = new System.Drawing.Size(903, 528);
            this.tbcvendedores.TabIndex = 5;
            this.tbcvendedores.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcvendedores_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvvendedores);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvvendedores
            // 
            this.dgvvendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvvendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvvendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvvendedores.Location = new System.Drawing.Point(3, 3);
            this.dgvvendedores.MultiSelect = false;
            this.dgvvendedores.Name = "dgvvendedores";
            this.dgvvendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvendedores.Size = new System.Drawing.Size(889, 485);
            this.dgvvendedores.TabIndex = 0;
            this.dgvvendedores.DoubleClick += new System.EventHandler(this.dgvvendedores_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idven";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 96;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 87;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "celular";
            this.Column2.HeaderText = "Celular";
            this.Column2.Name = "Column2";
            this.Column2.Width = 94;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "telefone";
            this.Column1.HeaderText = "Telefone";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "empresa";
            this.Column3.HeaderText = "Empresa";
            this.Column3.Name = "Column3";
            this.Column3.Width = 111;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mskcelular);
            this.tabPage2.Controls.Add(this.msktelefone);
            this.tabPage2.Controls.Add(this.txtempresa);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnlimpar);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtnome);
            this.tabPage2.Controls.Add(this.txtcodigo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtempresa
            // 
            this.txtempresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempresa.Location = new System.Drawing.Point(172, 269);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(476, 38);
            this.txtempresa.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Empresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Celular:";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(464, 58);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(149, 38);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(712, 372);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(159, 48);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(489, 372);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(159, 48);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Location = new System.Drawing.Point(270, 372);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(159, 48);
            this.btngravar.TabIndex = 6;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.Location = new System.Drawing.Point(44, 372);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(159, 48);
            this.btnincluir.TabIndex = 5;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(172, 125);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(697, 38);
            this.txtnome.TabIndex = 1;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(172, 58);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(255, 38);
            this.txtcodigo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // msktelefone
            // 
            this.msktelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktelefone.Location = new System.Drawing.Point(629, 195);
            this.msktelefone.Mask = "(00) 0000-0000";
            this.msktelefone.Name = "msktelefone";
            this.msktelefone.Size = new System.Drawing.Size(240, 38);
            this.msktelefone.TabIndex = 3;
            // 
            // mskcelular
            // 
            this.mskcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskcelular.Location = new System.Drawing.Point(172, 195);
            this.mskcelular.Mask = "(00) 00000-0000";
            this.mskcelular.Name = "mskcelular";
            this.mskcelular.Size = new System.Drawing.Size(277, 38);
            this.mskcelular.TabIndex = 2;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 528);
            this.Controls.Add(this.tbcvendedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "FrmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Vendedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVendedor_KeyDown);
            this.tbcvendedores.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendedores)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcvendedores;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvvendedores;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MaskedTextBox mskcelular;
        private System.Windows.Forms.MaskedTextBox msktelefone;
    }
}