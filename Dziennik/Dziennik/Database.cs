using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Dziennik
{
    class Database
    {
        private SQLiteConnection conn;

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
                    else if(reader.GetDataTypeName(i).ToLower() == "numeric")
                        line = reader.GetFloat(i).ToString();
                    else
                        line = reader.GetString(i);
                    list[i].Add(line);
                }
            }
            return list;
        }

        public bool Login(string login, string password)
        {
            if (ReadData("SELECT * FROM Login WHERE Login.Nr_albumu='" + login + "' AND Login.Haslo='" + password + "'")[0].Count!=0)
                return true;
            return false;
        }

        public List<Grade> Grades(string index)
        {
            List<Grade> list = new List<Grade>();
            List<List<string>> result = ReadData("SELECT Zajecia.Nazwa, Oceny.Ocena From Oceny INNER JOIN Zajecia ON Oceny.Zajecia_ID = Zajecia.ID WHERE Oceny.Nr_albumu = '" + index + "';");
            for (int i=0;i<result[0].Count;i++)
            {
                list.Add(new Grade(result[0][i], Convert.ToSingle(result[1][i]==""?"0":result[1][i])));
            }
            return list;
        }
        public List<Class> Classes(string index)
        {
            List<Class> list = new List<Class>();
            List<List<string>> result = ReadData("SELECT Plan.Data, Zajecia.Nazwa, Plan.Od, Plan.Do, Zajecia.Prowadzacy, Zajecia.Forma FROM Zajecia INNER JOIN ((Kierunek INNER JOIN Studenci ON Kierunek.ID = Studenci.Kierunek_ID) INNER JOIN Plan ON Kierunek.ID= Plan.Kierunek_ID) ON Zajecia.ID= Plan.Zajecia_ID WHERE Studenci.Nr_albumu='"+index+"';");
            for (int i = 0; i < result[0].Count; i++)
            {
                list.Add(new Class(result[0][i], result[1][i], result[2][i], result[3][i], result[4][i], result[5][i]));
            }
            return list;
        }
        public string Name(string index)
        {
            return ReadData("SELECT Studenci.Imie FROM Studenci WHERE Studenci.Nr_albumu = '" + index + "';")[0][0];
        }
        public string LastName(string index)
        {
            return ReadData("SELECT Studenci.Nazwisko FROM Studenci WHERE Studenci.Nr_albumu = '" + index + "';")[0][0];
        }
        public string Spec(string index)
        {
            return ReadData("SELECT Kierunek.Nazwa FROM Kierunek INNER JOIN	Studenci ON Kierunek.ID = Studenci.Kierunek_ID WHERE Studenci.Nr_albumu = '" + index + "';")[0][0];
        }
        public string Semester(string index)
        {
            return ReadData("SELECT Studenci.Semestr FROM Studenci WHERE Studenci.Nr_albumu = '" + index + "';")[0][0];
        }
        public void Close()
        {
            conn.Close();
        }
    }
}
        
