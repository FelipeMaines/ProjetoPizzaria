﻿using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloEndereco
{
    public interface IRepositorioEnderecoOrm : IRepositorioBaseOrm<Endereco>
    {
        Endereco SelecionarPorCep(string cep);

    }
}
