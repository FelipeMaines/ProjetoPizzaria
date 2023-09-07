using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloProdutos;
using ProjetoPizzaria.ModuloSabor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloIgrediente
{
    public class ControladorIgrediente : ControladorBase
    {
        private TabelaIgredientes tabelaIgredientes;
        public override string ToolTipInserir => "Cadastrar Igrediente";

        public override string ToolTipEditar => "Editar Igrediente";

        public override string ToolTipExcluir => "Excluir Igrediente";

        /// <summary>
        ///     override da classe ControladorBase, onde correga os itens cadastrados no sistema
        /// </summary>
        public override void CarregarItens()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para editar os itens já cadastrados no sistema
        /// </summary>
        public override void Editar()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para excluir os itens já cadastrados no sistema
        /// </summary>
        public override void Excluir()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para inseriros itens no sistema
        /// </summary>

        public override void Inserir()
        {
            var telaIgrediente = new TelaIgredienteForm();

            telaIgrediente.ShowDialog();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar a tebela/grid atual
        /// </summary>

        public override UserControl ObterTabela()
        {
            if (tabelaIgredientes == null)
                tabelaIgredientes = new TabelaIgredientes();

            return tabelaIgredientes;
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar qual sera o item a ser cadastado/editado/excluido de cadastro
        /// </summary>
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Igredientes";
        }
    }
}
