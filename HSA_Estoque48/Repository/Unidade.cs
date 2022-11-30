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
    public class Unidade : IUnidadeRepository
    {
        public int add(Model.Unidade modelUnidade)
        {
            int last_id;
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db"))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT INTO unidades (
                                            name,
                                            visible
                                        )
                                        VALUES (
                                            @name,
                                            @visible
                                        );
                ";
                command.Parameters.Add("@name", DbType.String).Value = modelUnidade.name;
                command.Parameters.Add("@visible", DbType.Boolean).Value = modelUnidade.visible;
                command.ExecuteNonQuery();
                command.CommandText = "select last_insert_rowid()";
                Int64 LastRowID64 = (Int64)command.ExecuteScalar();

                last_id = (int)LastRowID64;
            }
            return last_id;
        }

        public IEnumerable<Model.Unidade> findAll()
        {
            List<Model.Unidade> _findall = new List<Model.Unidade>();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db"))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT id,
                           name,
                           visible
                      FROM unidades
                     ORDER BY name;
                ";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model.Unidade modelUnidade = new Model.Unidade();
                        modelUnidade.id = reader.GetInt32(0);
                        modelUnidade.name = reader.GetString(1);
                        modelUnidade.visible = reader.GetBoolean(2);
                        _findall.Add(modelUnidade);
                    }
                }
            }
            return _findall;
        }

        public Model.Unidade get(int id)
        {
            Model.Unidade modelUnidade = new Model.Unidade();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db"))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT id,
                           name,
                           visible
                      FROM unidades
                     WHERE id = @id;
                ";
                command.Parameters.Add("@id", DbType.Int32).Value = id;
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    modelUnidade.id = reader.GetInt32(0);
                    modelUnidade.name = reader.GetString(1);
                    modelUnidade.visible = reader.GetBoolean(2);
                }
            }
            return modelUnidade;
        }
        public void update(Model.Unidade modelUnidade)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db"))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    UPDATE unidades
                       SET name = @name,
                           visible = @visible
                     WHERE id = @id;
                ";
                command.Parameters.Add("@name", DbType.String).Value = modelUnidade.name;
                command.Parameters.Add("@visible", DbType.Boolean).Value = modelUnidade.visible;
                command.Parameters.Add("@id", DbType.Int32).Value = modelUnidade.id;
                command.ExecuteNonQuery();
            }
        }
    }
}
