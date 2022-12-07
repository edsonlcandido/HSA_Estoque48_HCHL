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
    internal class Produto : IProdutoRepository
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

        public IEnumerable<Model.Produto> findAll()
        {
            throw new NotImplementedException();
        }

        public Model.Produto get(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Model.Produto produtoModel)
        {
            throw new NotImplementedException();
        }
    }
}
