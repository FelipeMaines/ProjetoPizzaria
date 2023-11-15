using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloSabor;
using ProjetoPizzariaDominio.ModuloValor;

namespace ProjetoPizzaria.ModuloValores
{
    public partial class TelaValorForm : Form
    {
        public Valor valor;
        public TelaValorForm()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EventTarget();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            CarregaEnumListBox();

        }

        private void CarregaEnumListBox()
        {
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));

            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        private void EventTarget()
        {
            txValor.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txValor.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txValorBorda.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txValorBorda.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            listBoxTamanho.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            listBoxTamanho.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            listBoxCategoria.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            listBoxCategoria.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }

        public Valor ObterValor()
        {
            return new Valor
            {
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                ValorPizza = decimal.Parse(txValor.Text),
                ValorBorda = decimal.Parse(txValorBorda.Text),
            };
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.valor = ObterValor();
        }
    }
}
