using ProjetoPizzaria.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private TabelaCliente tabelaCliente;
        public override string ToolTipInserir => "Cadastrar Cliente";

        public override string ToolTipEditar => "Editar Cliente";

        public override string ToolTipExcluir => "Excluir Cliente";

        public override void CarregarItens()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            telaCliente.ShowDialog();
        }

        public override UserControl ObterTabela()
        {
            if (tabelaCliente == null)
                this.tabelaCliente = new TabelaCliente();

            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }
    }
}
