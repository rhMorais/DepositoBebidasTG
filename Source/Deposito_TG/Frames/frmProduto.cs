using Domain;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Deposito_TG
{
    public partial class frmProduto : Form
    {
        ProdutoRepositorio _repo = new ProdutoRepositorio();
        VendedorRepositorio _repoVendedor = new VendedorRepositorio();

        public frmProduto()
        {
            InitializeComponent();
            modoIncluir();
        }

        private void Limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            numpreco.Value = 0;
            cmbvendedor.SelectedIndex = -1;
            modoIncluir();
            txtdescricao.Focus();
        }
        private void DgvDados()
        {
            try { dgvprodutos.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            DgvDados();
            carregarVendedores();
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void tbcprodutos_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcprodutos.SelectedIndex == 1)
            { txtdescricao.Focus(); return; }
            DgvDados();
        }

        private void dgvprodutos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int proCodigo = Convert.ToInt32(dgvprodutos.SelectedRows[0].Cells[Codigo.Name].Value);
                PreencherCampos(_repo.Selecionar(proCodigo));
                tbcprodutos.SelectedIndex = 1;
                modoEditar();
                txtdescricao.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.Salvar(getProduto());
                MessageBox.Show("Produto inserido com sucesso!");
                Limpar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.Salvar(getProduto());
                MessageBox.Show("Produto editado com sucesso!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.Excluir(Convert.ToInt32(txtcodigo.Text));
                MessageBox.Show("Produto excluído com sucesso!");
                Limpar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnovovendedor_Click(object sender, EventArgs e)
        {
            Close();
            new frmVendedor(true).ShowDialog();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void carregarVendedores()
        {
            try
            {
                var vendedores = _repoVendedor.Listar();
                Dictionary<string, int> p = new Dictionary<string, int>();
                foreach (var vendedor in vendedores)
                {
                    p.Add($"{vendedor.Nome} - {vendedor.Empresa}", vendedor.IdVen);
                }
                this.cmbvendedor.DataSource = new BindingSource(p, null);
                this.cmbvendedor.DisplayMember = "key";
                this.cmbvendedor.ValueMember = "value";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void indexVendedorSelecionado(int idpro)
        {
            for (var i = 0; i <= this.cmbvendedor.Items.Count - 1; i++)
            {
                this.cmbvendedor.SelectedIndex = i;
                if ((int)this.cmbvendedor.SelectedValue == idpro)
                    return;
            }
        }

        private void numpreco_Click(object sender, EventArgs e)
        {
            UpDownBase udb = numpreco;
            udb.Select(0, udb.Text.Length);
        }

        private Produto getProduto()
        {
            var codigo = txtcodigo.Text != "" ? Convert.ToInt16(txtcodigo.Text) : 0;
            return new Produto
            (
                codigo,
                txtdescricao.Text, 
                numpreco.Value,
                new Vendedor((int)cmbvendedor.SelectedValue)
            );
        }

        private void tbcprodutos_TabIndexChanged(object sender, EventArgs e)
        {
            if (tbcprodutos.SelectedIndex == 1)
                txtdescricao.Focus();
        }

        private void PreencherCampos(Produto produto)
        {
            txtcodigo.Text = produto.IdPro.ToString();
            txtcodigo.Text = produto.Descricao;
            txtdescricao.Text = produto.Descricao;
            numpreco.Value = produto.Preco;
            indexVendedorSelecionado(produto.IdPro);
        }
       
        private void modoIncluir()
        {
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
            btnincluir.Enabled = true;
        }
        private void modoEditar()
        {
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;
            btnincluir.Enabled = false;
        }
    }
}
}
