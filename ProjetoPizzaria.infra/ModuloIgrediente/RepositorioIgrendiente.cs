using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloIgrediente
{
    public class RepositorioIgrendiente : RepositorioBaseSql<Ingrediente, MapeadorIgrediente>, IRepositorioIgrediente
    {
        protected override string sqlInserir => @"INSERT INTO [igredientes]
                                                            (
                                                               [NOME]
                                                             )
                                                         VALUES
                                                             (
                                                                @NOME_IGREDIENTE
                                                              )
                                                SELECT SCOPE_IDENTITY();
                                                    ";

        //AA

        protected override string sqlEditar => @"UPDATE [igredientes] 
                                                SET
                                                    [NOME] = @NOME_IGREDIENTE
                                                WHERE
                                                    [ID_IGREDIENTE] = @id";

        protected override string sqlExcluir => @"DELETE FROM [igredientes]
	                                                WHERE 
		                                                [ID_IGREDIENTE] = @id";

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                    [id_igrediente]        ID_IGREDIENTE 
	                                                   ,[nome]                 NOME_IGREDIENTE 
                                                    FROM 
	                                                    [igredientes]";

        protected override string sqlSelecionarPorId =>
                                                    @"SELECT 
	                                                    [id_igrediente]        ID_IGREDIENTE
	                                                   ,[nome]                  NOME_IGREDIENTE
                                                    FROM 
	                                                    [igredientes] 
                                                    WHERE 
                                                        [id_igrediente] = @ID";

        protected override string sqlPesquisar =>
                                                    @" SELECT 
                                                        [id_igrediente] ID_IGREDIENTE,
                                                        [nome] NOME_IGREDIENTE 
                                                    FROM 
                                                        [igredientes]
                                                    WHERE 
                                                        nome LIKE '%' + @NOME + '%'";

    }
}
