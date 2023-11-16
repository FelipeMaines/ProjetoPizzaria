using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloCliente;
using ProjetoPizzariaDominio.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class TelaFuncionarioForm : Form
    {
        private IRepositorioEnderecoOrm repositorioEndereco;
        public Funcionario funcionario;
        public TelaFuncionarioForm(IRepositorioEnderecoOrm repositorioEndereco)
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EventTarget();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            this.repositorioEndereco = repositorioEndereco;
        }

        public void SetarTela(Funcionario funcionario)
        {
            this.funcionario = funcionario;

            txId.Text = funcionario.id.ToString();
            txNome.Text = funcionario.Nome;
            txMatricula.Text = funcionario.Matricula;
            txCarteira.Text = funcionario.Motorista;
            txEmail.Text = funcionario.Email;
            txSenha.Text = funcionario.Senha;
            if(funcionario.Validade.Date != Convert.ToDateTime("01/01/0001 00:00:0"))
                txValidade.Value = funcionario.Validade.Date;
            txDescricao.Text = funcionario.Observacao;
            txCpf.Text = funcionario.Cpf;
            txTelefone.Text = funcionario.Telefone;
            txNumero.Text = funcionario.Numero;
            txComplemento.Text = funcionario.Complemento;

            if (funcionario.Grupo == '1')
                radioButtonAdimin.Checked = true;

            else if(funcionario.Grupo == '2')
                radioButtonAtendente.Checked = true;

            else 
                radioButtonEntregador.Checked = true;

            EncherCamposEndereco(funcionario.Endereco);
        }

        private void EventTarget()
        {
            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txMatricula.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txMatricula.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txCarteira.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txCarteira.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txEmail.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txEmail.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txSenha.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txSenha.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txValidade.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txValidade.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txDescricao.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txDescricao.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txCpf.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txCpf.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txTelefone.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txTelefone.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txCep_Leave(object sender, EventArgs e)
        {
            var cepText = txCep.Text.Replace(".", "").Replace("-", "").Replace(",", "");

            if (cepText.Length != 8)
                return;

            Endereco cep = repositorioEndereco.SelecionarPorCep(cepText.Trim());

            if (cep != null)
                EncherCamposEndereco(cep);
        }

        private void EncherCamposEndereco(Endereco cep)
        {
            txLograduro.Text = cep.Logradouro;
            cbPais.Text = cep.Pais;
            cbCidade.Text = cep.Cidade;
            cbUf.Text = cep.Estado;
            txBairro.Text = cep.Bairro;
            txIdCep.Text = cep.id.ToString();

            if (txCep.Text.Length != 8)
                txCep.Text = cep.Cep;
        }

        private void ObterFuncionario()
        {
            string nome = txNome.Text;
            string cep = txCep.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            string cpf = txCpf.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            string matricula = txMatricula.Text;
            string email = txEmail.Text;
            char grupo = (radioButtonAdimin.Checked) ? '1' : (radioButtonAtendente.Checked) ? '2' : '3';
            string telefone = txTelefone.Text.Replace("(", "").Replace("-", "").Replace(")", "");
            string carteiraMotoriste = txCarteira.Text;
            DateTime validade = txValidade.Value;
            string senha = Funcoes.Sha256Hash(txSenha.Text);
            string descricao = txDescricao.Text;
            string numero = txNumero.Text;
            string complemento = txComplemento.Text;

            funcionario.Nome = nome;
            funcionario.Cpf = cpf;
            funcionario.Matricula= matricula;
            funcionario.Email = email;
            funcionario.Grupo = grupo;
            funcionario.Telefone = telefone;
            funcionario.Motorista = carteiraMotoriste;
            funcionario.Validade = validade;
            funcionario.Senha = senha;
            funcionario.Observacao = descricao;
            funcionario.Numero = numero;
            funcionario.Complemento = complemento;

            if (repositorioEndereco.SelecionarPorCep(cep) == null)
            {
                funcionario.Endereco.Logradouro = txLograduro.Text;
                funcionario.Endereco.Cep = cep;
                funcionario.Endereco.Cidade = cbCidade.Text;
                funcionario.Endereco.Estado = cbUf.Text;
                funcionario.Endereco.Pais = cbPais.Text;
                funcionario.Endereco.Bairro = txBairro.Text;
            }
            else
            {
                funcionario.Endereco = repositorioEndereco.SelecionarPorCep(cep);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ObterFuncionario();
        }
    }
}
