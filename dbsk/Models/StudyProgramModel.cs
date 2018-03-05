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

        public DataTable GetAllAliens()
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM alien;", dbcon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "result");
            DataTable StudyProgramsTable = ds.Tables["result"];
            dbcon.Close();
            return StudyProgramsTable;
        }
        public DataTable GetAllStudyPrograms()
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT distinct RaceName FROM alien;", dbcon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "result");
            DataTable StudyProgramsTable = ds.Tables["result"];
            dbcon.Close();
            return StudyProgramsTable;
        }

        public DataTable GetAllDanger()
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM DangerLevel;", dbcon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "result");
            DataTable DangerTable = ds.Tables["result"];
            dbcon.Close();
            return DangerTable;
        }

        public void DeleteAlien(string ID, string RaceName)
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            string deleteString = "DELETE FROM alien WHERE ID=@ID AND RaceName=@RaceName;";
            MySqlCommand sqlCmd = new MySqlCommand(deleteString, dbcon);
            sqlCmd.Parameters.AddWithValue("@ID", ID);
            sqlCmd.Parameters.AddWithValue("@RaceName", RaceName);
            int rows = sqlCmd.ExecuteNonQuery();
            dbcon.Close();

        }

        public void InsertAlien(string ID, string RaceName, string Color, int Danger)
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            string insertString = "INSERT INTO alien(ID,Danger,RaceName,Color) VALUES(@ID,@Danger,@RaceName,@Color)";
            MySqlCommand sqlCmd = new MySqlCommand(insertString, dbcon);
            sqlCmd.Parameters.AddWithValue("@ID", ID);
            sqlCmd.Parameters.AddWithValue("@Danger", Danger);
            sqlCmd.Parameters.AddWithValue("@RaceName", RaceName);
            sqlCmd.Parameters.AddWithValue("@Color", Color);
            int rows = sqlCmd.ExecuteNonQuery();
            dbcon.Close();
        }
        public void UpdateDanger(string ID, int Danger)
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            string updateString = "CALL UPDATEDANGER(@alienID, @alienDanger)";
            MySqlCommand sqlCmd = new MySqlCommand(updateString, dbcon);
            sqlCmd.Parameters.AddWithValue("@alienID", ID);
            sqlCmd.Parameters.AddWithValue("@alienDanger", Danger);
            int rows = sqlCmd.ExecuteNonQuery();
            dbcon.Close();

        }

    } 
}

