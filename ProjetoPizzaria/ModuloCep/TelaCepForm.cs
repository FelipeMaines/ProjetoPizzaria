using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.Properties;
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

            EventTarget();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void EventTarget()
        {
            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txBairro.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txBairro.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txLograduro.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txLograduro.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            cbPais.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            cbPais.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            cbUf.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            cbUf.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            cbCidade.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            cbCidade.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txBairro.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txBairro.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txCep.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txCep.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }
    }
}
