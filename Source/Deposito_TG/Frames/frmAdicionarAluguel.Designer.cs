namespace Deposito_TG
{
    partial class frmAdicionarAluguel
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
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
            this.groupBox2.Controls.Add(this.btngravar);
            this.groupBox2.Controls.Add(this.btnincluir);
            this.groupBox2.Location = new System.Drawing.Point(5, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1322, 453);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens:";
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 340);
            this.dataGridView1.TabIndex = 30;
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
            this.txttotalproduto.Location = new System.Drawing.Point(1160, 63);
            this.txttotalproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txttotalproduto.Name = "txttotalproduto";
            this.txttotalproduto.Size = new System.Drawing.Size(153, 29);
            this.txttotalproduto.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1156, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total item:";
            // 
            // txtvaloruniproduto
            // 
            this.txtvaloruniproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvaloruniproduto.Location = new System.Drawing.Point(965, 63);
            this.txtvaloruniproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtvaloruniproduto.Name = "txtvaloruniproduto";
            this.txtvaloruniproduto.Size = new System.Drawing.Size(136, 29);
            this.txtvaloruniproduto.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(961, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Vl Unit:";
            // 
            // cboproduto
            // 
            this.cboproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboproduto.FormattingEnabled = true;
            this.cboproduto.Location = new System.Drawing.Point(196, 60);
            this.cboproduto.Margin = new System.Windows.Forms.Padding(6);
            this.cboproduto.Name = "cboproduto";
            this.cboproduto.Size = new System.Drawing.Size(521, 32);
            this.cboproduto.TabIndex = 20;
            // 
            // txtquantidadeproduto
            // 
            this.txtquantidadeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidadeproduto.Location = new System.Drawing.Point(754, 63);
            this.txtquantidadeproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtquantidadeproduto.Name = "txtquantidadeproduto";
            this.txtquantidadeproduto.Size = new System.Drawing.Size(142, 29);
            this.txtquantidadeproduto.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(750, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Qtde:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Produto:";
            // 
            // txtcodigoproduto
            // 
            this.txtcodigoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoproduto.Location = new System.Drawing.Point(15, 63);
            this.txtcodigoproduto.Margin = new System.Windows.Forms.Padding(6);
            this.txtcodigoproduto.Name = "txtcodigoproduto";
            this.txtcodigoproduto.Size = new System.Drawing.Size(149, 29);
            this.txtcodigoproduto.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Código:";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(1175, 324);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(6);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(138, 58);
            this.btnexcluir.TabIndex = 19;
            this.btnexcluir.Text = "Excluir item";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(1175, 238);
            this.btngravar.Margin = new System.Windows.Forms.Padding(6);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(138, 58);
            this.btngravar.TabIndex = 18;
            this.btngravar.Text = "Editar item";
            this.btngravar.UseVisualStyleBackColor = true;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(1175, 152);
            this.btnincluir.Margin = new System.Windows.Forms.Padding(6);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(138, 59);
            this.btnincluir.TabIndex = 17;
            this.btnincluir.Text = "Incluir item";
            this.btnincluir.UseVisualStyleBackColor = true;
            // 
            // frmAdicionarAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 522);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Aluguel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
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
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
    }
}