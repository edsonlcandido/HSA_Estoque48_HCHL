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
    public class Historico : IHistoricoRepository
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

        public IEnumerable<Model.Historico> findAll()
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.Query<Model.Historico>(@"
                    SELECT dataMovimentacao,
                           usuario,
                           quantidadeMovimentada,
                           tipoMovimentacao,
                           produtoId,
                           solicitante,
                           pedidoCentroCusto,
                           notaFiscal,
                           obs
                      FROM historico;
                ");
            }
        }

        public IEnumerable<Model.Historico> reportAll()
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                var historicos =  connection.Query<Model.Historico, Model.Produto, Model.Historico>(@"
                    SELECT h.dataMovimentacao,
                           h.usuario,
                           h.quantidadeMovimentada,
                           h.tipoMovimentacao,
                           h.produtoId,
                           h.solicitante,
                           h.pedidoCentroCusto,
                           h.notaFiscal,
                           h.obs,
                           p.id,
                           p.descricao,
                           p.quantidadeMinima,
                           p.quantidadeMaxima,
                           p.quantidadeTotal,
                           p.leadTime,
                           p.tipo,
                           p.unidade,
                           p.localizacao,
                           p.caixa
                      FROM historico AS h
                           LEFT JOIN
                           produtos AS p ON h.produtoId = p.id;
                ",(historico, produto) => { historico.produto = produto; return historico; } );
                return historicos;
            }
        }

    }
}
