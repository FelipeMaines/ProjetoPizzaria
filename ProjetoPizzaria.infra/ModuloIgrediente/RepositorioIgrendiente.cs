using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloIgrediente
{
    public class RepositorioIgrendiente : RepositorioBaseSql<Igrediente, MapeadorIgrediente>, IRepositorioIgrediente
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

        protected override string sqlEditar => @"UPDATE [igredientes] 
                                                SET
                                                    [NOME] = @NOME_IGREDIENTE
                                                WHERE
                                                    [ID] = @ID_IGREDIENTE";

        protected override string sqlExcluir => @"DELETE FROM [igredientes]
	                                                WHERE 
		                                                [ID] = @ID_IGREDIENTE";

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
                                                        [id_igrediente] = @ID_IGREDIENTE";

        public void Editar(int id, Igrediente registro)
        {
            throw new NotImplementedException();
        }
    }
}
