using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace TestMSSQL
{
    class DBData
    {
        private static SqlConnection connection = DBConnection.Connect();
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static SqlCommand command;
        private static Random Rand = new Random();

        private static string[] searcQuerys = {"select FacID AS 'Номер факультету', FacName AS 'Назва факультету' from Faculties",
                                                "select LecFacID AS 'Номер факультету', LecID AS 'Номер кафедри', LecName AS 'Назва кафедри' from Lecterns",
                                                "select SpecLecID AS 'Номер кафедри', SpecID AS 'Номер спецiальностi', SpecName AS 'Назва спецiальностi', SpecProg AS 'Освiтня програма' from Specialitys",
                                                "select GrpSpecID AS 'Номер спецiальностi', GrpID AS 'Номер групи', GrpYear AS 'Рiк початку навчання', GrpState AS 'Скороченний термiн' from Groups",
                                                "select * from allPublicStudentsData"};

        #region Int Querys
        public static int GetIndex(string what, string from, string where)
        {
            connection.Open();
            int res = 0;

            command = new SqlCommand("select " + what + " from " + from + " where " + where, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                res = reader.GetInt32(0);
            }

            reader.Close();
            connection.Close();
            return res;
        }
        #endregion

        #region String Querys
        public static string[] GetComboData(string from)
        {
            connection.Open();
            List<string> result = new List<string>();

            command = new SqlCommand("select * from " + from, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
                reader.NextResult();
            }
            reader.Close();

            string[] res = new string[result.Count];
            for (int i = 0; i < result.Count; i++)
            {
                res[i] = result[i].ToString();
            }

            connection.Close();
            return res;
        }

        public static string[] GetComboData(string what, string from)
        {
            connection.Open();
            List<string> result = new List<string>();

            command = new SqlCommand("select " + what + " from " + from, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
                reader.NextResult();
            }
            reader.Close();

            string[] res = new string[result.Count];
            for(int i = 0; i < result.Count; i++)
            {
                res[i] = result[i].ToString();
            }
            
            connection.Close();
            return res;
        }

        public static string[] GetComboData(string what, string from, string where)
        {
            connection.Open();
            List<string> result = new List<string>();

            command = new SqlCommand("select " + what + " from " + from + " where " + where, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
                reader.NextResult();
            }
            reader.Close();

            string[] res = new string[result.Count];
            for (int i = 0; i < result.Count; i++)
            {
                res[i] = result[i].ToString();
            }

            connection.Close();
            return res;
        }
        #endregion

        #region Table Querys
        public static DataTable GetStudentsData(string group)
        {
            connection.Open();
            DataTable table = new DataTable();

            command = new SqlCommand("select * from allPublicStudentsData where Група = '" + group + "'", connection);
            adapter.SelectCommand = command;
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            connection.Close();
            return table;
        }

        public static DataTable GetAllData(int stateIndex)
        {
            connection.Open();
            DataTable table = new DataTable();

            command = new SqlCommand(searcQuerys[stateIndex], connection);
            adapter.SelectCommand = command;
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            connection.Close();
            return table;
        }
        #endregion

        #region Data Generators
        private void GenerateGroups()
        {
            connection.Open();
            string[] lines = File.ReadAllLines(@"..\..\GeneratorsTxt\Groups.txt");
            foreach (string s in lines)
            {
                List<int> specIndexes = new List<int>();

                int idIndex = s.IndexOf(',');
                string lecture = s.Substring(idIndex).Trim(',');
                string group = s.Remove(idIndex, 4).Trim(',', '\'');

                SqlCommand command = new SqlCommand("select * from Specialitys where SpecLecID = " + lecture, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        specIndexes.Add(reader.GetInt32(0));
                    }
                    reader.NextResult();
                }
                reader.Close();

                int progIndex = specIndexes[Rand.Next(0, specIndexes.Count)];

                command = new SqlCommand("insert into Groups(GrpID, GrpSpecID, GrpYear) values('" + group + "'," + progIndex + ",'" + Rand.Next(2016, 2021) + "')", connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void GenerateStudents()
        {
            connection.Open();
            List<string> groups = new List<string>();

            SqlCommand command = new SqlCommand("select GrpID from Groups", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    groups.Add(reader.GetString(0));
                }
                reader.NextResult();
            }
            reader.Close();

            foreach (string group in groups)
            {
                int courseIndex = Rand.Next(1, 5);
                for (int i = 0; i <= Rand.Next(3, 23); i++)
                {
                    command = new SqlCommand("insert into Students(StdGrpID, StdCourse) values('" + group + "'," + courseIndex + ")", connection);
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void GenerateStudentData()
        {
            connection.Open();
            string[] SNames = File.ReadAllLines(@"..\..\GeneratorsTxt\Fams.txt");
            string[] MFNames = File.ReadAllLines(@"..\..\GeneratorsTxt\MFName.txt");
            string[] GFNames = File.ReadAllLines(@"..\..\GeneratorsTxt\GFName.txt");
            string[] MMNames = File.ReadAllLines(@"..\..\GeneratorsTxt\MMName.txt");
            string[] GMNames = File.ReadAllLines(@"..\..\GeneratorsTxt\GMName.txt");
            List<int> students_ids = new List<int>();
            List<string> students_tickets = new List<string>();

            SqlCommand command = new SqlCommand("select * from students_tickets", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    students_ids.Add(reader.GetInt32(0));
                    students_tickets.Add(reader.GetString(1));
                }
                reader.NextResult();
            }
            reader.Close();

            foreach (int student in students_ids)
            {
                if (Rand.Next(0, 1000) >= 500)
                {
                    command = new SqlCommand("insert into StudentData(DataLName, DataFName, DataMName, DataTicID, DataRecordBook) values('"
                        + SNames[Rand.Next(0, SNames.Length)] + "','"
                        + MFNames[Rand.Next(0, MFNames.Length)] + "','"
                        + MMNames[Rand.Next(0, MMNames.Length)] + "','"
                        + students_tickets[student - 1] + "',"
                        + (Rand.Next(100000, 999999) + Rand.Next(10000, 99999)) + ")", connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new SqlCommand("insert into StudentData(DataLName, DataFName, DataMName, DataTicID, DataRecordBook) values('"
                        + SNames[Rand.Next(0, SNames.Length)] + "','"
                        + GFNames[Rand.Next(0, GFNames.Length)] + "','"
                        + GMNames[Rand.Next(0, GMNames.Length)] + "','"
                        + students_tickets[student - 1] + "',"
                        + (Rand.Next(100000, 999999) + Rand.Next(10000, 99999)) + ")", connection);
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void GenerateTickets()
        {
            connection.Open();
            List<int> students_ids = new List<int>();
            List<int> students_facs = new List<int>();
            List<DateTime> students_dates = new List<DateTime>();

            SqlCommand command = new SqlCommand("select * from students_facs", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    students_ids.Add(reader.GetInt32(0));
                    students_facs.Add(reader.GetInt32(1));
                    students_dates.Add(reader.GetDateTime(2));
                }
                reader.NextResult();
            }
            reader.Close();

            char[] arr_EN = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int index = 10000000;
            foreach (int id in students_ids)
            {
                int k1 = Rand.Next(0, 25);
                int k2 = Rand.Next(0, 25);
                int k3 = index;
                string TicketID = arr_EN[k1].ToString() + arr_EN[k2].ToString() + k3.ToString();

                DateTime dateIN = students_dates[id - 1];
                DateTime dateOUT = dateIN.AddYears(4);

                command = new SqlCommand("insert into Tickets(TicID, TicStdID, TicFacID, TicGetDate, TicOutDate) values('" + TicketID + "'," + students_ids[id - 1] + "," + students_facs[id - 1] + ", '" + dateIN + "','" + dateOUT + "')", connection);
                command.ExecuteNonQuery();

                index++;
            }
            connection.Close();
        }
        #endregion
    }
}
