namespace Deposito_TG
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bensAlocáveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeBensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAtendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.bensAlocáveisToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.atendentesToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1153, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(87, 28);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(112, 28);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoDePedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // manutençãoDePedidosToolStripMenuItem
            // 
            this.manutençãoDePedidosToolStripMenuItem.Name = "manutençãoDePedidosToolStripMenuItem";
            this.manutençãoDePedidosToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.manutençãoDePedidosToolStripMenuItem.Text = "Manutenção de Pedidos";
            this.manutençãoDePedidosToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDePedidosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoDeProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // manutençãoDeProdutosToolStripMenuItem
            // 
            this.manutençãoDeProdutosToolStripMenuItem.Name = "manutençãoDeProdutosToolStripMenuItem";
            this.manutençãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            this.manutençãoDeProdutosToolStripMenuItem.Text = "Manutenção de Produtos";
            this.manutençãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeProdutosToolStripMenuItem_Click);
            // 
            // bensAlocáveisToolStripMenuItem
            // 
            this.bensAlocáveisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoDeBensToolStripMenuItem});
            this.bensAlocáveisToolStripMenuItem.Name = "bensAlocáveisToolStripMenuItem";
            this.bensAlocáveisToolStripMenuItem.Size = new System.Drawing.Size(151, 28);
            this.bensAlocáveisToolStripMenuItem.Text = "Bens Alocáveis";
            // 
            // manutençãoDeBensToolStripMenuItem
            // 
            this.manutençãoDeBensToolStripMenuItem.Name = "manutençãoDeBensToolStripMenuItem";
            this.manutençãoDeBensToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.manutençãoDeBensToolStripMenuItem.Text = "Manutenção de bens";
            this.manutençãoDeBensToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeBensToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(89, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // manutençãoDeClientesToolStripMenuItem
            // 
            this.manutençãoDeClientesToolStripMenuItem.Name = "manutençãoDeClientesToolStripMenuItem";
            this.manutençãoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(284, 28);
            this.manutençãoDeClientesToolStripMenuItem.Text = "Manutenção de Clientes";
            this.manutençãoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeClientesToolStripMenuItem_Click);
            // 
            // atendentesToolStripMenuItem
            // 
            this.atendentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaAtendentesToolStripMenuItem});
            this.atendentesToolStripMenuItem.Name = "atendentesToolStripMenuItem";
            this.atendentesToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.atendentesToolStripMenuItem.Text = "Atendentes";
            // 
            // consultaAtendentesToolStripMenuItem
            // 
            this.consultaAtendentesToolStripMenuItem.Name = "consultaAtendentesToolStripMenuItem";
            this.consultaAtendentesToolStripMenuItem.Size = new System.Drawing.Size(313, 28);
            this.consultaAtendentesToolStripMenuItem.Text = "Manutenção de Atendentes";
            this.consultaAtendentesToolStripMenuItem.Click += new System.EventHandler(this.consultaAtendentesToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoDeVendedoresToolStripMenuItem});
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(127, 28);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // manutençãoDeVendedoresToolStripMenuItem
            // 
            this.manutençãoDeVendedoresToolStripMenuItem.Name = "manutençãoDeVendedoresToolStripMenuItem";
            this.manutençãoDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.manutençãoDeVendedoresToolStripMenuItem.Text = "Manutenção de Vendedores";
            this.manutençãoDeVendedoresToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeVendedoresToolStripMenuItem_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 733);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPrincipal";
            this.Text = "Deposito de bebidas - Tudo para sua festa!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAtendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bensAlocáveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeBensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeVendedoresToolStripMenuItem;
    }
}

