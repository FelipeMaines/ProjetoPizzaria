using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloCliente;
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
    public partial class TabelaCliente : UserControl
    {
        public TabelaCliente()
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
                    Name = "nome",
                    HeaderText = "nome"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "cpf",
                    HeaderText = "cpf"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "Email",
                    HeaderText = "Email"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "Telefone",
                    HeaderText = "Telefone"
                },
                    new DataGridViewTextBoxColumn()
                {
                    Name = "enderecoId",
                    HeaderText = "Endereco Id"
                }
            };

            grid.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente item in clientes)
                grid.Rows.Add(item.id,
                            item.Nome,
                            item.Cpf,
                            item.Email,
                            item.Telefone,
                            item.EnderecoId);
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

