using HSA_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Dapper;
using System.Xml.Linq;
using System.Configuration;

namespace HSA_Estoque.Repository
{
    public class Tipo : ITipoRepository
    {
        string CONNECTIONSTRING = HSA_Estoque.Properties.Settings.Default["ConnectionString"].ToString();
        public int add(Model.Tipo modelTipo)
        {
            int last_id;
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                last_id = connection.Query<int>(@"
                    INSERT INTO tipos (
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
                    name=modelTipo.name,
                    visible=modelTipo.visible
                }).Single();
            }
            return last_id;
        }

        public IEnumerable<Model.Tipo> findAll()
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.Query<Model.Tipo>(@"
                    SELECT id,
                           name,
                           visible
                      FROM tipos
                     ORDER BY name;
                ");
            }
        }

        public Model.Tipo get(int id)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.QueryFirstOrDefault<Model.Tipo>(@"
                    SELECT id,
                           name,
                           visible
                      FROM tipos
                     WHERE id = @id;
                ", new { id = id });
            }
        }
        public void update(Model.Tipo modelTipo)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                connection.Execute(@"
                    UPDATE tipos
                       SET name = @name,
                           visible = @visible
                     WHERE id = @id;
                ", new
                {
                    id= modelTipo.id,
                    name= modelTipo.name,
                    visible= modelTipo.visible,
                });
            }
        }
    }
}
