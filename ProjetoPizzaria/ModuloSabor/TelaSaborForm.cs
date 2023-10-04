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

namespace ProjetoPizzaria.ModuloSabor
{
    public partial class TelaSaborForm : Form
    {
        public TelaSaborForm()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EventTarget();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

        }

        private void EventTarget()
        {
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            txNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            txNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            pictureBox.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            pictureBox.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            checkedListBox1.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            checkedListBox1.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            ListBoxCategoria.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            ListBoxCategoria.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            ListBoxTipo.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            ListBoxTipo.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
        }
    }
}
