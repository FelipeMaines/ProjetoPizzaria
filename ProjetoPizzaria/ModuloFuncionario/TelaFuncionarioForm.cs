using ProjetoPizzaria.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class TelaFuncionarioForm : Form
    {
        public TelaFuncionarioForm()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EventTarget();

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
    }
}
