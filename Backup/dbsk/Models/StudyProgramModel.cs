using MySql.Data.MySqlClient;
using System.Data;

namespace dbsk7.Models
{
    public class StudyProgramModel
    {
        private string connectionString = "";

        public StudyProgramModel()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["wwwlab.iki.his.se-dbsk"].ConnectionString;
        }

        public DataTable GetAllStudyPrograms()
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM StudyProgram;", dbcon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "result");
            DataTable StudyProgramsTable = ds.Tables["result"];
            dbcon.Close();
            return StudyProgramsTable;
        }
    }
}