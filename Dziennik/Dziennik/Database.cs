using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Dziennik
{
    /// <summary>
    /// Represents database containing students' data.
    /// </summary>
    public class Database
    {
        private SQLiteConnection conn;
        /// <summary>
        /// Initialize connection with the "Dzienniczek.db" database.
        /// </summary>
        public Database()
        {
            string dir = Directory.GetCurrentDirectory();
            dir = Path.Combine(dir.Remove(dir.Length - 10), @"Database\Dzienniczek.db");
            conn = new SQLiteConnection("Data Source=" + dir + "; Version = 3; Read Only=True; ");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database cannot be open");
            }
        }
        /// <summary>
        /// Executes a SQL query to the database.
        /// </summary>
        /// <param name="command">An SQL query in the form of text.</param>
        /// <returns>Result-set of specified SQL query for Dzienniczek database.</returns>
        private List<List<string>> ReadData(string command)
        {
            List<List<string>> list = new List<List<string>>();
            SQLiteDataReader reader;
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = command;
            reader = cmd.ExecuteReader();

            for (int i = 0; reader.GetDataTypeName(i) != ""; i++)
                list.Add(new List<string>());

            while (reader.Read())
            {
                for (int i = 0; reader.GetDataTypeName(i) != ""; i++)
                {
                    string line;
                    string sda = reader.GetDataTypeName(i).ToLower();

                    if (reader.IsDBNull(i))
                        line = "";
                    else if (reader.GetDataTypeName(i).ToLower() == "integer")
                        line = reader.GetInt32(i).ToString();
                    else if (reader.GetDataTypeName(i).ToLower() == "numeric")
                        line = reader.GetFloat(i).ToString();
                    else
                        line = reader.GetString(i);
                    list[i].Add(line);
                }
            }
            return list;
        }
        /// <summary>
        /// Checks whether a user with a specific login and password exists.
        /// </summary>
        /// <returns>True if there is any, false if there is not.</returns>
        public bool Login(string login, string password)
        {
            if (ReadData("SELECT * FROM Login WHERE Login.Nr_albumu='" + login + "' AND Login.Haslo='" + password + "'")[0].Count != 0)
                return true;
            return false;
        }
        /// <summary>
        /// Gets student's grades from database.
        /// </summary>
        /// <param name="index">Student's index.</param>
        /// <returns>List of grades.</returns>
        public List<Grade> GetGrades(string index)
        {
            List<Grade> list = new List<Grade>();
            List<List<string>> result = ReadData("SELECT Zajecia.Nazwa, Oceny.Ocena From Oceny INNER JOIN Zajecia ON Oceny.Zajecia_ID = Zajecia.ID WHERE Oceny.Nr_albumu = '" + index + "';");
            for (int i = 0; i < result[0].Count; i++)
            {
                list.Add(new Grade(result[0][i], Convert.ToSingle(result[1][i] == "" ? "0" : result[1][i])));
            }
            return list;
        }
        /// <summary>
        /// Gets student's classes from database.
        /// </summary>
        /// <param name="index">Student's index.</param>
        /// <returns>List of classes.</returns>
        public List<Class> GetClasses(string index)
        {
            List<Class> list = new List<Class>();
            List<List<string>> result = ReadData("SELECT Plan.Data, Zajecia.Nazwa, Plan.Od, Plan.Do, Zajecia.Prowadzacy, Zajecia.Forma FROM Zajecia INNER JOIN ((Kierunek INNER JOIN Studenci ON Kierunek.ID = Studenci.Kierunek_ID) INNER JOIN Plan ON Kierunek.ID= Plan.Kierunek_ID) ON Zajecia.ID= Plan.Zajecia_ID WHERE Studenci.Nr_albumu='" + index + "';");
            for (int i = 0; i < result[0].Count; i++)
            {
                list.Add(new Class(result[0][i], result[1][i], result[2][i], result[3][i], result[4][i], result[5][i]));
            }
            return list;
        }
        /// <summary>
        /// Gets student's name from database.
        /// </summary>
        /// <param name="index">Student's index.</param>
        /// <returns>Student's name.</returns>
        public string GetName(string index)
        {
            return ReadData("SELECT Studenci.Imie FROM Studenci WHERE Studenci.Nr_albumu = '" + index + "';")[0][0];
        }
        /// <summary>
        /// Gets student's last name from database.
        /// </summary>
        /// <param name="index">Student's index.</param>
        /// <returns>Student's last name.</returns>
        public string GetLastName(string index)
        {
            return ReadData("SELECT Studenci.Nazwisko FROM Studenci WHERE Studenci.Nr_albumu = '" + index + "';")[0][0];
        }
        /// <summary>
        /// Gets student's specialization from database.
        /// </summary>
        /// <param name="index">Student's index.</param>
        /// <returns>Student's specialization.</returns>
        public string GetSpec(string index)
        {
            return ReadData("SELECT Kierunek.Nazwa FROM Kierunek INNER JOIN	Studenci ON Kierunek.ID = Studenci.Kierunek_ID WHERE Studenci.Nr_albumu = '" + index + "';")[0][0];
        }
        /// <summary>
        /// Gets student's semester from database.
        /// </summary>
        /// <param name="index">Student's index.</param>
        /// <returns>Student's semester.</returns>
        public string GetSemester(string index)
        {
            return ReadData("SELECT Studenci.Semestr FROM Studenci WHERE Studenci.Nr_albumu = '" + index + "';")[0][0];
        }
        /// <summary>
        /// Closes the connection with database.
        /// </summary>
        public void Close()
        {
            conn.Close();
        }
    }
}

