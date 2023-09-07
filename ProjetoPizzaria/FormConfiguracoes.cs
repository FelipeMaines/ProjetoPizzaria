using ProjetoPizzaria.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            EncherComboBox();
            Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            //seleciona no comboBox o idioma/cultura atual
            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
        }

        private void EncherComboBox()
        {
            List<string> idiomas = new List<string>
            {
                "pt-BR",
                "en-US",
                "es"
            };


            for (int i = 0; i < idiomas.Count; i++)
            {
                comboBoxIdioma.Items.Add(idiomas[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            LinguagemSelecionada.fechaAplicacao = ConfigurationManager.AppSettings.Get("IdiomaRegiao") == comboBoxIdioma.Text;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //atualiza a cultura corrente
            Program.AjustaIdiomaRegiao();
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso!");
        }
    }
}
