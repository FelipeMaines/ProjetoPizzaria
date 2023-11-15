using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloIgrediente;
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
    public partial class TabelaCep : UserControl
    {
        public TabelaCep()
        {
            InitializeComponent();
            ConfigurarColunas();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(this.grid);
            ConfiguracaoGrid.ConfigurarGridZebrado(this.grid);
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cep",
                    HeaderText = "Cep"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "logradouro",
                    HeaderText = "Logradouro"
                },
                     new DataGridViewTextBoxColumn()
                {
                    Name = "bairro",
                    HeaderText = "Bairro"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "cidade",
                    HeaderText = "Cidade"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "uf",
                    HeaderText = "Uf"
                },
                    new DataGridViewTextBoxColumn()
                {
                    Name = "Pais",
                    HeaderText = "Pais"
                }
            };

            grid.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Endereco> listaEndereco)
        {
            grid.Rows.Clear();

            foreach (Endereco item in listaEndereco)
                grid.Rows.Add(item.id,
                            item.Cep,
                            item.Logradouro,
                            item.Bairro,
                            item.Cidade,
                            item.Estado,
                            item.Pais);
        }

        public int ObterIdSelecionado()
        {
            if (grid.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
