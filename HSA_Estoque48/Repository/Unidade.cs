using HSA_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace HSA_Estoque.Repository
{
    public class Unidade : IUnidadeRepository
    {
        string CONNECTIONSTRING = "Data Source=inventory.db";
        public int add(Model.Unidade modelUnidade)
        {
            int last_id;
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                last_id = connection.Query<int>(@"
                    INSERT INTO unidades (
                                            name,
                                            visible
                                        )
                                        VALUES (
                                            @name,
                                            @visible
                                        );
                    SELECT last_insert_rowid();
                ", new
                {
                    name = modelUnidade.name,
                    visible = modelUnidade.visible
                }).Single();
            }
            return last_id;
        }

        public IEnumerable<Model.Unidade> findAll()
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.Query<Model.Unidade>(@"
                    SELECT id,
                           name,
                           visible
                      FROM unidades
                     ORDER BY name;
                ");
            }
        }

        public Model.Unidade get(int id)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.QueryFirstOrDefault<Model.Unidade>(@"
                    SELECT id,
                           name,
                           visible
                      FROM unidades
                     WHERE id = @id;
                ", new { id = id });
            }
        }
        public void update(Model.Unidade modelUnidade)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                connection.Execute(@"
                    UPDATE unidades
                       SET name = @name,
                           visible = @visible
                     WHERE id = @id;
                ", new
                {
                    id = modelUnidade.id,
                    name = modelUnidade.name,
                    visible = modelUnidade.visible,
                });
            }
        }
    }
}
