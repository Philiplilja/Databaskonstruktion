using System.Data;
using MySql.Data.MySqlClient;


namespace dbsk7.Models
{
    public class StudentsModel
    {
        private string connectionString = "";

        public StudentsModel(string connectionName)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public DataTable SearchStudents(string name, string studyProgram)
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM alien WHERE ID LIKE @name AND RaceName=@studyProgram;", dbcon);
            adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + name + "%");
            adapter.SelectCommand.Parameters.AddWithValue("@studyProgram", studyProgram);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "result");
            DataTable StudentsTable = ds.Tables["result"];
            dbcon.Close();
            return StudentsTable;
        }
    }
}