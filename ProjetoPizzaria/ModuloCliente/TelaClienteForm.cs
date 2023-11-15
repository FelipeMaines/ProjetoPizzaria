using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.infra.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloCliente;
using ProjetoPizzariaDominio.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private IRepositorioEnderecoOrm repositorioEndereco;
        public Cliente cliente;
        public TelaClienteForm(IRepositorioEnderecoOrm repositorioEndereco)
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EnventosTarget();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            this.repositorioEndereco = repositorioEndereco;
        }

        public TelaClienteForm(IRepositorioEnderecoOrm repositorioEndereco, Cliente cliente)
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EnventosTarget();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            this.repositorioEndereco = repositorioEndereco;

            this.repositorioEndereco = repositorioEndereco;
            this.cliente = cliente;

            SetarTela();
        }

        private void SetarTela()
        {
            txId.Text = cliente.id.ToString();
            txCpf.Text = cliente.Cpf.ToString();
            txCep.Text = cliente.Cpf.ToString();
            txNome.Text = cliente.Nome;
            txComplemento.Text = cliente.Complemento;
            txNumero.Text = cliente.Numero;
            txEmail.Text = cliente.Email;
            txTelefone.Text = cliente.Telefone;

            EncherCampoEndereco(repositorioEndereco.SelecionarPorId(cliente.EnderecoId));
        }

        private void EnventosTarget()
        {
            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txEmail.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txEmail.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txCpf.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txCpf.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txTelefone.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txTelefone.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txCep_Leave(object sender, EventArgs e)
        {
            var cepText = txCep.Text.Replace(".", "").Replace("-", "").Replace(",", "");

            if (cepText.Length != 8)
                return;

            Endereco cep = repositorioEndereco.SelecionarPorCep(cepText.Trim());

            if (cep != null)
                EncherCampoEndereco(cep);
        }

        private Cliente ObterCliente()
        {
            string nome = txNome.Text;
            string cpf = txCpf.Text.Replace(".", "").Replace("-", "").Replace(",", ""); 
            string cep = txCep.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            string telefone = txTelefone.Text.Replace("(", "").Replace("-", "").Replace(")", "");
            string email = txEmail.Text;
            string numero = txNumero.Text;
            string complemento = txComplemento.Text;
            int enderecoId = Convert.ToInt32(txIdCep.Text);

            return new Cliente(nome, cpf, telefone, email, enderecoId, numero, complemento);
        }

        private void EncherCampoEndereco(Endereco cep)
        {
            txLograduro.Text = cep.Logradouro;
            cbPais.Text = cep.Pais;
            cbCidade.Text = cep.Cidade;
            cbUf.Text = cep.Cidade;
            txBairro.Text = cep.Bairro;
            txIdCep.Text = cep.id.ToString();

            if (txCep.Text.Length != 8)
                txCep.Text = cep.Cep;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cliente = ObterCliente();

            if (txId.Text != null && txId.Text != "")
            {
                int id = Convert.ToInt32(txId.Text);
                cliente.id = id;
            }
        }
    }
}
