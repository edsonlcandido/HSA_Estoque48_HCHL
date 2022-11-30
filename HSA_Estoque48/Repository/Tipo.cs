using HSA_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace HSA_Estoque.Repository
{
    public class Tipo : ITipoRepository
    {
        public int add(Model.Tipo modelTipo)
        {
            int last_id;
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db"))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT INTO tipos (
                                            name,
                                            visible
                                        )
                                        VALUES (
                                            @name,
                                            @visible
                                        );
                ";
                command.Parameters.Add("@name", DbType.String).Value = modelTipo.name;
                command.Parameters.Add("@visible", DbType.Boolean).Value = modelTipo.visible;
                command.ExecuteNonQuery();
                command.CommandText = "select last_insert_rowid()";
                Int64 LastRowID64 = (Int64)command.ExecuteScalar();

                last_id = (int)LastRowID64;
            }
            return last_id;
        }

        public IEnumerable<Model.Tipo> findAll()
        {
            List<Model.Tipo> _findall = new List<Model.Tipo>();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db"))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT id,
                           name,
                           visible
                      FROM tipos
                     ORDER BY name;
                ";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model.Tipo modelTipo = new Model.Tipo();
                        modelTipo.id = reader.GetInt32(0);
                        modelTipo.name = reader.GetString(1);
                        modelTipo.visible = reader.GetBoolean(2);
                        _findall.Add(modelTipo);
                    }
                }
            }
            return _findall;
        }

        public Model.Tipo get(int id)
        {
            Model.Tipo modelTIpo = new Model.Tipo();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db"))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT id,
                           name,
                           visible
                      FROM tipos
                     WHERE id = @id;
                ";
                command.Parameters.Add("@id", DbType.Int32).Value = id;
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    modelTIpo.id = reader.GetInt32(0);
                    modelTIpo.name = reader.GetString(1);
                    modelTIpo.visible = reader.GetBoolean(2);
                }
            }
            return modelTIpo;
        }
        public void update(Model.Tipo modelTipo)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db"))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    UPDATE tipos
                       SET name = @name,
                           visible = @visible
                     WHERE id = @id;
                ";
                command.Parameters.Add("@name", DbType.String).Value = modelTipo.name;
                command.Parameters.Add("@visible", DbType.Boolean).Value = modelTipo.visible;
                command.Parameters.Add("@id", DbType.Int32).Value = modelTipo.id;
                command.ExecuteNonQuery();
            }
        }
    }
}
