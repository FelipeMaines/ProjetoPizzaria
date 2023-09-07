using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }

        public string TooTipDevolucao = "Devolução de Aluguel";

        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return true; } }
        public virtual bool ExcluirHabilitado { get { return true; } }

        /// <summary>
        /// Metodo abstrato para inserção de itens no sistema 
        /// </summary>
        public abstract void Inserir();
        /// <summary>
        /// Metodo abstrato para edição de itens no sistema 
        /// </summary>
        public abstract void Editar();
        /// <summary>
        /// Metodo abstrato para exclusão de itens no sistema 
        /// </summary>
        public abstract void Excluir();
        /// <summary>
        /// Metodo abstrato para obter a tabela atual
        /// </summary>
        public abstract UserControl ObterTabela();
        /// <summary>
        /// Metodo abstrato para obter qual o item atual
        /// </summary>
        public abstract string ObterTipoCadastro();
        /// <summary>
        /// Metodo abstrato para carregar os itens ja cadastrados no sistema
        /// </summary>
        public abstract void CarregarItens();
    }
}
