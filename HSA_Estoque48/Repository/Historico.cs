using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HSA_Estoque.Repository
{
    public class Historico : IHistorcoRepository
    {
        string CONNECTIONSTRING = HSA_Estoque.Properties.Settings.Default["ConnectionString"].ToString();
        public int Add(Model.Historico modelHistorico)
        {
            int last_id;
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                last_id = connection.Query<int>(@"
                    INSERT INTO historico (
                                              dataMovimentacao,
                                              usuario,
                                              quantidadeMovimentada,
                                              tipoMovimentacao,
                                              produtoId,
                                              solicitante,
                                              pedidoCentroCusto,
                                              notaFiscal,
                                              obs
                                          )
                                          VALUES (
                                              @dataMovimentacao,
                                              @usuario,
                                              @quantidadeMovimentada,
                                              @tipoMovimentacao,
                                              @produtoId,
                                              @solicitante,
                                              @pedidoCentroCusto,
                                              @notaFiscal,
                                              @obs
                                          );
                    SELECT last_insert_rowid();
                ", modelHistorico).Single();
            }
            return last_id;
        }

        public IEnumerable<Model.Unidade> findAll()
        {
            throw new NotImplementedException();
        }
    }
}
