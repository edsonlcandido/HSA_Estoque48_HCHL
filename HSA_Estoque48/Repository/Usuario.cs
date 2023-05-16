using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using Dapper;
using System.Linq;
using HSA_Estoque.Model;

namespace HSA_Estoque.Repository
{
    public class Usuario : IUsuarioRepository
    {
        string CONNECTIONSTRING = HCHL_Inventario.Properties.Settings.Default["ConnectionString"].ToString();
        public int add(Model.Usuario modelUsuario)
        {
            int last_id;
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                last_id = connection.Query<int>(@"
                    INSERT INTO usuarios (
                                             nome,
                                             isAdmin
                                         )
                                         VALUES (
                                             @nome,
                                             @isAdmin
                                         );
                    SELECT last_insert_rowid();
                ", modelUsuario).Single();
            }
            return last_id;
        }

        public IEnumerable<Model.Usuario> getAll()
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                return connection.Query<Model.Usuario>(@"
                    SELECT id,
                           nome,
                           isAdmin
                      FROM usuarios;
                ");
            }
        }

        public void update(Model.Usuario modelUsuario)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTIONSTRING))
            {
                var affectedRows = connection.Execute(@"
                    UPDATE usuarios
                       SET nome = @nome,
                           isAdmin = @isAdmin
                     WHERE id = @id;
                ", modelUsuario);
            }
        }
    }
}