using Domain;
using Repositorio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Deposito_TG
{
    public partial class frmProduto : Form
    {
        private readonly ProdutoRepositorio _repo = new ProdutoRepositorio();
        private readonly VendedorRepositorio _repoVendedor = new VendedorRepositorio();

        public frmProduto()
        {
            InitializeComponent();
            ModoIncluir();
        }

        private void Limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            numpreco.Value = 0;
            cmbvendedor.SelectedIndex = -1;
            ModoIncluir();
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
            CarregarVendedores();
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelectNextControl(ActiveControl, !e.Shift, true, true, true);
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
                var proCodigo = Convert.ToInt32(dgvprodutos.SelectedRows[0].Cells[Codigo.Name].Value);
                PreencherCampos(_repo.Selecionar(proCodigo));
                tbcprodutos.SelectedIndex = 1;
                ModoEditar();
                txtdescricao.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.Salvar(GetProduto());
                MessageBox.Show("Produto inserido com sucesso!");
                Limpar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.Salvar(GetProduto());
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
            new FrmVendedor(true).ShowDialog();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void CarregarVendedores()
        {
            try
            {
                var vendedores = _repoVendedor.Listar();
                var p = vendedores.ToDictionary(vendedor => $"{vendedor.Nome} - {vendedor.Empresa}", vendedor => vendedor.IdVen);
                cmbvendedor.DataSource = new BindingSource(p, null);
                cmbvendedor.DisplayMember = "key";
                cmbvendedor.ValueMember = "value";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void IndexVendedorSelecionado(int idpro)
        {
            for (var i = 0; i <= cmbvendedor.Items.Count - 1; i++)
            {
                cmbvendedor.SelectedIndex = i;
                if ((int)cmbvendedor.SelectedValue == idpro)
                    return;
            }
        }

        private void numpreco_Click(object sender, EventArgs e)
        {
            UpDownBase udb = numpreco;
            udb.Select(0, udb.Text.Length);
        }

        private Produto GetProduto()
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
            IndexVendedorSelecionado(produto.IdPro);
        }
       
        private void ModoIncluir()
        {
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
            btnincluir.Enabled = true;
        }
        private void ModoEditar()
        {
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;
            btnincluir.Enabled = false;
        }
    }
}

