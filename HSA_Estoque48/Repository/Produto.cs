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
        string CONNECTIONSTRING = HSA_Estoque.Properties.Settings.Default["ConnectionString"].ToString();

        public int add(Model.Produto produtoModel)
        {
            using(IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                var affectedRows = connection.Execute(@"
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
                                             caixa
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
                                             @caixa
                                         );
                    ",
                    produtoModel);
            }
            return produtoModel.id;
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
                           caixa       
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
                           caixa       
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
                           caixa
                      FROM produtos;
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
                           caixa
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
                           caixa = @caixa
                     WHERE id = @id;
                ", produtoModel);
            }
        }   
    }
}
