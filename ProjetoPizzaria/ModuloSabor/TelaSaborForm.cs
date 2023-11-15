using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;
using ProjetoPizzariaDominio.ModuloSabor;
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
        private List<Ingrediente> ingredientes;
        public Sabor sabor;
        public TelaSaborForm(IRepositorioIngredienteOrm repositorioIgrediente)
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EventTarget();

            CarregaEnumListBox();

            this.ingredientes = repositorioIgrediente.SelecionarTodos();

            CarregarComboBoxIgredientes();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        public TelaSaborForm(IRepositorioIngredienteOrm repositorioIgrediente, Sabor sabor)
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            this.ingredientes = repositorioIgrediente.SelecionarTodos();

            EventTarget();

            CarregaEnumListBox();

            CarregarComboBoxIgredientes();

            this.sabor = sabor;

            SetarTela();

        }

        private void SetarTela()
        {
            txNome.Text = this.sabor.Descricao;
            txId.Text = sabor.id.ToString();
            pictureBox.Image = Funcoes.ConverteByteArrayParaImagem(sabor.Foto);
            ListBoxCategoria.Text = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(sabor.Categoria.ToString()));
            ListBoxTipo.Text = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(sabor.Tipo.ToString()));

            foreach(var igrediente in sabor.SaborIngredientes)
            {
                for (int i = 0; i < cbIgredientes.Items.Count; i++)
                {
                    if (igrediente.nome == ((Ingrediente)cbIgredientes.Items[i]).nome.ToString())
                    {
                        cbIgredientes.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxCategoria
            ListBoxCategoria.Items.Clear();
            ListBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
            //popular listBoxTipo
            ListBoxTipo.Items.Clear();
            ListBoxTipo.DataSource = Enum.GetValues(typeof(EnumSaborTipo));
        }

        private void CarregarComboBoxIgredientes()
        {
            foreach (var item in ingredientes)
                cbIgredientes.Items.Add(item);
        }

        private void EventTarget()
        {
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            txNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            txNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            pictureBox.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            pictureBox.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            cbIgredientes.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            cbIgredientes.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            ListBoxCategoria.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            ListBoxCategoria.Enter += new EventHandler(Funcoes.CampoEventoEnter!);

            ListBoxTipo.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
            ListBoxTipo.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
        }

        public Sabor ObterSabor()
        {
            string Descricao = txNome.Text;
            var Foto = Funcoes.ConverteImagemParaByteArray(pictureBox.Image);
            var Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), ListBoxCategoria.Text);
            var Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), ListBoxTipo.Text);
            var SaborIngredientes = cbIgredientes.CheckedItems.OfType<Ingrediente>().ToList();

            return new Sabor(Descricao, Foto, Categoria, Tipo, SaborIngredientes);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImagem = new()
            {
                Title = "Imagem do produto",
                Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF"
            };
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBox.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                pictureBox.Image = (Image)(new Bitmap(pictureBox.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.sabor = ObterSabor();
        }
    }
}
