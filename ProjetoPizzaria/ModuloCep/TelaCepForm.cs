using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.Properties;
using ProjetoPizzariaDominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloCep
{
    public partial class TelaCepForm : Form
    {
        public Endereco enderco;
        public TelaCepForm()
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


            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var pais = txPais.Text;
            var cep = txCep.Text;
            var estado = txUf.Text;
            var cidade = txCidade.Text;
            var logradouro = txLograduro.Text;
            var bairro = txBairro.Text;

            this.enderco = new Endereco(pais, cep, logradouro, bairro, cidade, estado);
        }
    }
}
