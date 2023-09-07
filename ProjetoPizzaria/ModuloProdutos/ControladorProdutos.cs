using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloSabor;
using ProjetoPizzaria.ModuloValores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloProdutos
{
    public class ControladorProdutos : ControladorBase
    {
        private TabelaProdutos tabelaProdutos;
        public override string ToolTipInserir => "Cadastrar Produtos";

        public override string ToolTipEditar => "Editar Produtos";

        public override string ToolTipExcluir => "Excluir Produtos";

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
            var telaProduto = new TelaProdutoForm();

            telaProduto.ShowDialog();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar a tebela/grid atual
        /// </summary>
        public override UserControl ObterTabela()
        {
            if (tabelaProdutos == null)
                tabelaProdutos = new TabelaProdutos();

            return tabelaProdutos;
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar uma string com o nome do item a ser cadastado/editado/excluido com proposito de mostrar na tela
        /// </summary>
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Produtos";
        }
    }
}
