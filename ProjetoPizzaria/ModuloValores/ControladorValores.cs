using ProjetoPizzaria.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloValores
{
    public class ControladorValores : ControladorBase
    {
        private TabelaValores tabelaValores;
        public override string ToolTipInserir => "Cadastrar Valores";

        public override string ToolTipEditar => "Editar Valores";

        public override string ToolTipExcluir => "Excluir Valores";
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
            TelaValorForm telaValoresForm = new TelaValorForm();

            telaValoresForm.ShowDialog();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar a tebela/grid atual
        /// </summary>
        public override UserControl ObterTabela()
        {
            if (tabelaValores == null)
                tabelaValores = new TabelaValores();

            return tabelaValores;
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar uma string com o nome do item a ser cadastado/editado/excluido com proposito de mostrar na tela
        /// </summary>
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Valores";
        }
    }
}
