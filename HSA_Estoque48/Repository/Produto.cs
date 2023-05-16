using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Repository
{
    public class Produto : IProdutoRepository
    {
        string CONNECTIONSTRING = HCHL_Inventario.Properties.Settings.Default["ConnectionString"].ToString();

        public int add(Model.Produto produtoModel)
        {
            int lastRow;
            using(IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                lastRow = connection.Query<int>(@"
                    INSERT INTO produtos (
                                             id,
                                             descricao,
                                             quantidadeMinima,
                                             quantidadeMaxima,
                                             quantidadeTotal,
                                             leadTime,
                                             tipo,
                                             unidade,
                                             localizacao,
                                             caixa,
                                             obs
                                         )
                                         VALUES (
                                             @id,
                                             @descricao,
                                             @quantidadeMinima,
                                             @quantidadeMaxima,
                                             @quantidadeTotal,
                                             @leadTime,
                                             @tipo,
                                             @unidade,
                                             @localizacao,
                                             @caixa,
                                             @obs
                                         );
                        SELECT last_insert_rowid();
                    ",
                    produtoModel).Single();
            }
            return lastRow;
        }

        public void delete(Model.Produto produtoModel)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                var affectedRows = connection.Execute(@"
                    DELETE FROM produtos
                          WHERE id = @id
                ", new { produtoModel.id });
            }
        }

        public IEnumerable<Model.Produto> filterByDescricao(string descricao)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.Query<Model.Produto>(@"
                    SELECT id,
                           descricao,
                           quantidadeMinima,
                           quantidadeMaxima,
                           quantidadeTotal,
                           leadTime,
                           tipo,
                           unidade,
                           localizacao,
                           caixa,
                           obs
                      FROM produtos
                      WHERE descricao LIKE @descricao;
                ", new { descricao = "%" + descricao + "%"});
            }
        }

        public IEnumerable<Model.Produto> filterByID(string id)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.Query<Model.Produto>(@"
                    SELECT id,
                           descricao,
                           quantidadeMinima,
                           quantidadeMaxima,
                           quantidadeTotal,
                           leadTime,
                           tipo,
                           unidade,
                           localizacao,
                           caixa,
                           obs
                      FROM produtos
                      WHERE id LIKE @id;
                ", new { id = "%" + id + "%" });
            }
        }

        public IEnumerable<Model.Produto> findAll()
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.Query<Model.Produto>(@"
                    SELECT id,
                           descricao,
                           quantidadeMinima,
                           quantidadeMaxima,
                           quantidadeTotal,
                           leadTime,
                           tipo,
                           unidade,
                           localizacao,
                           caixa,
                           obs
                      FROM produtos
                     ORDER BY descricao;
                ");
            }
        }

        public Model.Produto get(int id)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.QuerySingle<Model.Produto>(@"
                    SELECT id,
                           descricao,
                           quantidadeMinima,
                           quantidadeMaxima,
                           quantidadeTotal,
                           leadTime,
                           tipo,
                           unidade,
                           localizacao,
                           caixa,
                           obs
                      FROM produtos
                     WHERE id = @id;
                ", new {id = id});
            }
        }

        public void update(Model.Produto produtoModel)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                var affectedRows = connection.Execute(@"
                    UPDATE produtos
                       SET descricao = @descricao,
                           quantidadeMinima = @quantidadeMinima,
                           quantidadeMaxima = @quantidadeMaxima,
                           quantidadeTotal = @quantidadeTotal,
                           leadTime = @leadTime,
                           tipo = @tipo,
                           unidade = @unidade,
                           localizacao = @localizacao,
                           caixa = @caixa,
                           obs = @obs
                     WHERE id = @id;
                ", produtoModel);
            }
        }   
    }
}
