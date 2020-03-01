using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Core
{
    public class DtBase
    {
        protected static SqlCommand command
        {
            get;
            set;
        }

        protected static DataTable table
        {
            get;
            set;
        }

        protected static int counter
        {
            get;
            set;
        }

        public static SqlConnection connection = new SqlConnection
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=S:\database.mdf; Integrated Security=True; Connect Timeout=30"
        };
        
        public static class Executar
        {
            public static bool NonQuery()
            {
                int counter = 0;

                try
                {
                    connection.Open();
                    counter = command.ExecuteNonQuery();
                }
                catch (SqlException sqlex)
                {
                	MessageBox.Show(sqlex.Message, Msg.Title.Erro);
                }
                finally
                {
                    connection.Close();
                }

                return counter.Equals(1);
            }

            public static DataTable Reader(string cmdText, object value1 = null, object value2 = null, object value3 = null, object value4 = null)
            {
                SqlDataReader reader;

                table = new DataTable();

                try
                {
                    connection.Open();

                    command = new SqlCommand(cmdText, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    
                    if (value1 != null)
                    {
                        command.Parameters.AddWithValue("@value1", value1);
                    }

                    if (value2 != null)
                    {
                        command.Parameters.AddWithValue("@value2", value2);
                    }

                    if (value3 != null)
                    {
                        command.Parameters.AddWithValue("@value3", value3);
                    }

                    if (value4 != null)
                    {
                        command.Parameters.AddWithValue("@value4", value4);
                    }

                    reader = command.ExecuteReader();
                    table.Load(reader);
                }
                catch (SqlException sqlex)
                {
                	MessageBox.Show(sqlex.Message, Msg.Title.Erro);
                }
                finally
                {
                    connection.Close();
                }

                return table;
            }
        }
    }
}
