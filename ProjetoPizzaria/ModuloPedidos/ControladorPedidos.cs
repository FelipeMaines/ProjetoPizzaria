﻿using ProjetoPizzaria.Compartilhado;
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
            throw new NotImplementedException();
        }

        public override UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Pedidos";
        }
    }
}
