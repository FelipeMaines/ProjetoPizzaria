using ProjetoPizzaria.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloPedidos
{
    public class ControladorPedidos : ControladorBase
    {
        public override string ToolTipInserir => "Cadastr de Pedidos";

        public override string ToolTipEditar => "Editar Pedidos";

        public override string ToolTipExcluir => "Excluir Pedidos";

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
            throw new NotImplementedException();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar a tebela/grid atual
        /// </summary>
        public override UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar qual sera o item a ser cadastado/editado/excluido de cadastro
        /// </summary>
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Pedidos";
        }
    }
}
