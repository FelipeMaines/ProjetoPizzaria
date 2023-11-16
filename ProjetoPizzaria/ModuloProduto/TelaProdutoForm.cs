using Org.BouncyCastle.Asn1.BC;
using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloProduto;
using ProjetoPizzariaDominio.ModuloSabor;
using ProjetoPizzariaDominio.ModuloValor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloProduto
{
    public partial class TelaProdutoForm : Form
    {
        public Produto produto;
        public TelaProdutoForm()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            CarregaEnumListBox();
        }

        public TelaProdutoForm(Produto produto) : this()
        {
            this.produto = produto;

            SetarTela();
        }

        private void CarregaEnumListBox()
        {
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));

            listBoxTamanho.Items.Clear();
            listBoxTamanho.Items.Add("150");
            listBoxTamanho.Items.Add("300");
            listBoxTamanho.Items.Add("600");
            listBoxTamanho.Items.Add("1000");
            listBoxTamanho.Items.Add("1500");
            listBoxTamanho.Items.Add("2000");

        }

        private void SetarTela()
        {
            txId.Text = produto.id.ToString();
            txNome.Text = produto.Descricao;
            txValor.Text = produto.Descricao.ToString();
            listBoxTipo.Text = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(produto.Tipo.ToString()));
        }

        private Produto ObterProduto()
        {
            return new Produto
            {
                Descricao = txNome.Text,
                Valor = decimal.Parse(txValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                ML = listBoxTamanho.Text,
            };
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            produto = ObterProduto();
        }
    }
}
