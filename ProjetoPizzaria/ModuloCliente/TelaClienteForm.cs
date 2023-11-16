using Microsoft.Identity.Client.Extensibility;
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

        public void SetarTela(Cliente cliente)
        {
            this.cliente = cliente;

            txId.Text = cliente.id.ToString();
            txCpf.Text = cliente.Cpf;
            txCep.Text = cliente.Endereco.Cep;
            txNome.Text = cliente.Nome;
            txComplemento.Text = cliente.Complemento;
            txNumero.Text = cliente.Numero;
            txEmail.Text = cliente.Email;
            txTelefone.Text = cliente.Telefone;


            EncherCampoEndereco(cliente.Endereco);
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

        private void ObterCliente()
        {
            string nome = txNome.Text;
            string cpf = txCpf.Text.Replace(".", "").Replace("-", "").Replace(",", ""); 
            string cep = txCep.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            string telefone = txTelefone.Text.Replace("(", "").Replace("-", "").Replace(")", "");
            string email = txEmail.Text;
            string numero = txNumero.Text;
            string complemento = txComplemento.Text;

            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.Telefone = telefone;
            cliente.Email = email;
            cliente.Numero = numero;
            cliente.Complemento = complemento;

            if(repositorioEndereco.SelecionarPorCep(cep) == null)
            {
                cliente.Endereco.Logradouro = txLograduro.Text;
                cliente.Endereco.Cep = cep;
                cliente.Endereco.Cidade = cbCidade.Text;
                cliente.Endereco.Estado = cbUf.Text;
                cliente.Endereco.Pais = cbPais.Text;
                cliente.Endereco.Bairro = txBairro.Text;
            }
            else
            {
                cliente.Endereco = repositorioEndereco.SelecionarPorCep(cep);
            }
           
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
            ObterCliente();
        }
    }
}
