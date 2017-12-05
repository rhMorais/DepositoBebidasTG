using Domain;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Deposito_TG
{
    public partial class FrmPedido : Form
    {
        private readonly PedidoRepositorio _repo = new PedidoRepositorio();
        private readonly ClienteRepositorio _repoClientes = new ClienteRepositorio();
        private static readonly ProdutoRepositorio RepoProdutos = new ProdutoRepositorio();
        private readonly AtendenteRepositorio _repoAtendentes = new AtendenteRepositorio();
        private List<Itens> _listaItens = new List<Itens>();

        private readonly List<Produto> _listaDeProdutos = RepoProdutos.Listar().ToList(); 

        public FrmPedido() { InitializeComponent(); }

        public FrmPedido(bool aba)
        {
            InitializeComponent();
            if (aba) tbcpedido.SelectedIndex = 1;
        }

        private void Limpar()
        {
            txtcodigopedido.Clear();
            txtobservacao.Clear();
            txtcodigoproduto.Clear();
            txtquantidadeproduto.Clear();
            txtvaloruniproduto.Clear();
            txtvalortotal.Clear();
            txtdesconto.Clear();
            txttotalproduto.Clear();
            cboatendente.SelectedIndex = -1;
            cboproduto.SelectedIndex = -1;
            cbocliente.SelectedIndex = -1;
            txtcodigopedido.Focus();
        }

        private void DgvDados()
        {
            try { dgvpedido.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            DgvDados();
            CarregarClientes();
            CarregarProdutos();
            CarregarAtendentes();
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelectNextControl(ActiveControl, !e.Shift, true, true, true);
        }

        private void tbcpedido_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcpedido.SelectedIndex == 1)
            { tbcpedido.Focus(); return; }
            DgvDados();
        }

        private void dgvpedido_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var pedCodigo = Convert.ToInt32(dgvpedido.SelectedRows[0].Cells[Codigo.Name].Value);
                PreencherCampos(_repo.Selecionar(pedCodigo));
                tbcpedido.SelectedIndex = 1;
                cbocliente.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNovoCliente_Click_1(object sender, EventArgs e)
        {
            Form f = new frmCliente();
            f.Show();
        }

        private void cboproduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produto = new Produto();
            if (cboproduto.SelectedValue.GetType() == typeof(int) ||  cboproduto.SelectedIndex != 0)
            {
                var codigo = Convert.ToInt32(cboproduto.SelectedValue);
                produto = _listaDeProdutos.First(x => x.IdPro == codigo);
            }
            else
            {
                var codigo = cboproduto.SelectedValue.ToString().Replace("[","").Replace("]","").Split(',');
                produto = _listaDeProdutos.First(x => x.IdPro == Convert.ToInt32(codigo[1]));
            }
            txtcodigoproduto.Text = produto.IdPro.ToString();
            txtvaloruniproduto.Text = $"{produto.Preco:0,0.00}";
            TotalItem();
        }

        private void CarregarAtendentes()
        {
            try
            {
                CarregarCombo(_repoAtendentes.Listar().ToDictionary(atendente => atendente.Nome, atendente => atendente.IdAten), cboatendente);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void CarregarClientes()
        {
            try
            {
                CarregarCombo(_repoClientes.Listar().ToDictionary(cliente => $"{cliente.Nome} - {cliente.Cpf}", cliente => cliente.IdCli), cbocliente);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void CarregarProdutos()
        {
            try
            {
                CarregarCombo(_listaDeProdutos.ToDictionary(produto => produto.Descricao, produto => produto.IdPro), cboproduto);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void CarregarCombo(Dictionary<string, int> dicionario, ComboBox combo)
        {
            combo.DataSource = new BindingSource(dicionario, null);
            combo.DisplayMember = "key";
            combo.ValueMember = "value";
            
        }

        private static void IndexComboSelecionado(int id, ComboBox combo)
        {
            for (var i = 0; i <= combo.Items.Count - 1; i++)
            {
                combo.SelectedIndex = i;
                if ((int)combo.SelectedValue == id)
                    return;
            }
        }

        private void PreencherCampos(Pedido pedido)
        {
            txtcodigopedido.Text = pedido.IdPed.ToString();
            txtobservacao.Text = pedido.Observacao;
            txtdesconto.Text = pedido.Desconto.ToString(CultureInfo.CurrentCulture);
            txtvalortotal.Text = pedido.VlTotal.ToString(CultureInfo.CurrentCulture);
            IndexComboSelecionado(pedido.Cliente.IdCli, cbocliente);
            IndexComboSelecionado(pedido.Atendente.IdAten, cboatendente);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtquantidadeproduto_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int) e.KeyCode <= 48 || (int) e.KeyCode >= 57) return;
            TotalItem();
        }

        private void TotalItem()
        {
            var qtde = txtquantidadeproduto.Text != "" ? Convert.ToDecimal(txtquantidadeproduto.Text) : 0;
            var preco = Convert.ToDecimal(txtvaloruniproduto.Text);
            var totalitem = qtde * preco;
            txttotalproduto.Text = $"{totalitem:0,0.00}";
        }

        private void txtcodigoproduto_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode <= 48 || (int)e.KeyCode >= 57) return;
            IndexComboSelecionado(Convert.ToInt32(txtcodigoproduto.Text), cboproduto );
        }

        private void btnincluir_Click_1(object sender, EventArgs e)
        {
            var item = new Itens( 
                _listaDeProdutos.First(x => x.IdPro == Convert.ToInt32(txtcodigoproduto.Text)),
                Convert.ToInt32(txtquantidadeproduto.Text),
                Convert.ToDecimal(txttotalproduto.Text)
                );
            _listaItens.Add(item);

            var list = _listaItens.Select(x => new
            {
                idPro = x.Produto.IdPro,
                descricao = x.Produto.Descricao,
                quantidade = x.Quantidade,
                precounitario = $"R$ {x.Produto.Preco:0,0.00}",
                total = $"R$ {x.Total:0,0.00}"
            }).ToList();

            txtvalortotal.Text = $"R$ {_listaItens.Sum(x => x.Total):0,0.00}";
            dgvItens.DataSource = list;
        }

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
