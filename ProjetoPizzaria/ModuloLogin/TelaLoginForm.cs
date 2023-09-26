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

namespace ProjetoPizzaria.ModuloLogin
{
    public partial class TelaLoginForm : Form
    {
        public TelaLoginForm()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            txUsuario.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txUsuario.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txSenha.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txSenha.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
