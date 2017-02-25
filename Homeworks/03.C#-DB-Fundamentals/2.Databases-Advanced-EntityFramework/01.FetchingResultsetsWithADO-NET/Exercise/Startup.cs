namespace Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main()
        {

            SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;");

            connection.Open();

            // string sqlCreateDB = "CREATE DATABASE MinionsDB";
            // SqlCommand createDBCommand = new SqlCommand(sqlCreateDB, connection);

            using (connection)
            {
                // createDBCommand.ExecuteNonQuery();
                // CreateAndInsertTables(connection);

                Console.WriteLine("Enter a valid digit which corresponds to the actions below:");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("2. Get Villains Names");
                Console.WriteLine("3. Find Minions By Villain Id");
                Console.WriteLine("4. Add a Minion");
                Console.WriteLine("5. Change Town Names Casing");
                Console.WriteLine("7. Print All Minion Names");
                Console.WriteLine("8. Increase Minions Age");
                Console.WriteLine("9. Increase Age Stored Procedure");
                Console.WriteLine("-----------------------------------------------------------");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 2: GetVillainsNames(connection); break;
                    case 3: FindMinionsByVillainId(connection); break;
                    case 4: AddMinion(connection); break;
                    case 5: TownsToUpperCase(connection); break;
                    case 7: PrintAllMinionNames(connection); break;
                    case 8: IncreaseAge(connection); break;
                    case 9: IncreaseAgeProc(connection); break;
                    default: Console.WriteLine("Invalid action chosen."); ; break;
                }

            }
        }

        private static void IncreaseAgeProc(SqlConnection connection)
        {
            int ageParam = int.Parse(Console.ReadLine());

            string increaseAge =
            File.ReadAllText("../../09.usp_GetOlder.sql");

            SqlCommand increaseAgeCommand =
            new SqlCommand(increaseAge, connection);

            SqlParameter param =
            new SqlParameter("@mid", ageParam);

            increaseAgeCommand.Parameters.Add(param);
            try
            {
                SqlDataReader reader = increaseAgeCommand.ExecuteReader();
                if (reader.Read())
                {
                    Console.WriteLine($"{(string)reader["Name"]} {(int)reader["Age"]}");
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Console.WriteLine("Invalid ID of an Minion entered.");
            }  
        }

        private static void IncreaseAge(SqlConnection connection)
        {
            Console.WriteLine("You are about to enter the minions IDs separated by a single space.");
            Console.WriteLine("All chosen minions will have their age instantly increased.");
            int[] ids = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            string idsParam = String.Join(",", ids);

            string increaseAge =
                File.ReadAllText("../../08.MinionAge.sql");

            SqlCommand increaseAgeCommand =
                new SqlCommand(increaseAge, connection);

            SqlParameter param1 =
                new SqlParameter("@idsParam", idsParam);

            increaseAgeCommand.Parameters.Add(param1);

            SqlDataReader reader = increaseAgeCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{(string)reader["Name"]} {(int)reader["Age"]}");
            }
        }

        private static void PrintAllMinionNames(SqlConnection connection)
        {
            string queryCountNames = "USE MinionsDB SELECT COUNT(*) AS Count FROM Minions";
            SqlCommand printMinionNames =
                new SqlCommand(queryCountNames, connection);
            SqlDataReader reader = printMinionNames.ExecuteReader();
            int last = 0;
            if (reader.Read())
            {
                last = (int)reader["Count"];
            }
            reader.Close();
            string queryAllNames = "USE MinionsDB SELECT Name FROM Minions";
            SqlCommand printAllMinionNames =
                new SqlCommand(queryAllNames, connection);
            SqlDataReader readerNames = printAllMinionNames.ExecuteReader();
            List<string> list = new List<string>();
            while (readerNames.Read())
            {
                list.Add((string)readerNames["Name"]);
            }
            while (list.Count() > 0)
            {
                Console.WriteLine(list.First());
                list.RemoveAt(0);
                if (list.Count() > 0)
                {
                    Console.WriteLine(list.Last());
                    list.RemoveAt(last - 2);
                    last--;
                }
                last--;
            }
        }

        private static void TownsToUpperCase(SqlConnection connection)
        {
            string country = Console.ReadLine();

            string changeToUpperQuery = File.ReadAllText("../../05.ChangeTownNames.sql");

            SqlCommand changeToUpperCommand = new SqlCommand(changeToUpperQuery, connection);

            SqlParameter countryName =
                new SqlParameter("@countryName", country);
            changeToUpperCommand.Parameters.Add(countryName);

            SqlDataReader reader = changeToUpperCommand.ExecuteReader();
            int count = 0;
            List<string> townsList = new List<string>();
            using (reader)
            {
                while (reader.Read())
                {
                    count++;
                    townsList.Add(reader[0].ToString());
                }
            }

            changeToUpperCommand.ExecuteNonQuery();
            if (count > 0)
            {
                Console.WriteLine($"{count} town names were affected.");
                Console.WriteLine($"[{String.Join(", ", townsList)}]");
            }
            else
            {
                Console.WriteLine("No town names were affected.");
            }
        }

        private static void AddMinion(SqlConnection connection)
        {
            Console.Write("Minion: ");
            string[] arr = Console.ReadLine().Split(' ')
                .ToArray();

            Console.Write("Villain: ");
            string villain = Console.ReadLine();

            string isTownExist = "USE MinionsDB SELECT * FROM Towns WHERE Name = @town";
            SqlCommand isTownExistComand = new SqlCommand(isTownExist, connection);
            SqlParameter town = new SqlParameter("@town", arr[2]);
            isTownExistComand.Parameters.Add(town);

            SqlDataReader reader = isTownExistComand.ExecuteReader();
            if (!reader.Read())
            {
                Console.Write("Country: ");
                string countryName = Console.ReadLine();

                string addMinionQuery = File.ReadAllText("../../04.AddMinionIf.sql");
                SqlCommand addMinionComand = new SqlCommand(addMinionQuery, connection);

                addMinionComand.Parameters.AddRange(new[]
                {
                        new SqlParameter("@name", arr[0]),
                        new SqlParameter("@age", int.Parse(arr[1])),
                        new SqlParameter("@town", arr[2]),
                        new SqlParameter("@villain", villain),
                        new SqlParameter("@country", countryName)
                    });
                reader.Close();
                Console.WriteLine(addMinionComand.ExecuteNonQuery());
                Console.WriteLine($"{arr[0]} and {arr[2]} ware added");

            }
            else
            {
                string addMinionQuery = File.ReadAllText("../../04.AddMinionElse.sql");
                SqlCommand addMinionComand = new SqlCommand(addMinionQuery, connection);

                addMinionComand.Parameters.AddRange(new[]
                {
                        new SqlParameter("@name", arr[0]),
                        new SqlParameter("@age", int.Parse(arr[1])),
                        new SqlParameter("@town", arr[2]),
                        new SqlParameter("@villain", villain)
                    });
                reader.Close();
                Console.WriteLine(addMinionComand.ExecuteNonQuery());
                Console.WriteLine($"Successfully added {arr[0]} to be minion of {villain}.");
            }
        }

        private static void FindMinionsByVillainId(SqlConnection connection)
        {
            int idToSearch = int.Parse(Console.ReadLine());

            string searchQuery = File.ReadAllText(@"../../03.VillainById.sql");

            SqlCommand findVillainNameComand = new SqlCommand(searchQuery, connection);
            SqlParameter villainParam =
                  new SqlParameter("@villainId", idToSearch);
            findVillainNameComand.Parameters.Add(villainParam);

            SqlDataReader reader = findVillainNameComand.ExecuteReader();

            if (reader.Read())
            {
                string villainName = (string)reader["name"];
                Console.WriteLine($"Villain: {villainName}");

                string findMinionsQuery = File.ReadAllText("../../03.SearchMinions.sql");
                SqlCommand findMinionsCommand = new SqlCommand(findMinionsQuery, connection);
                SqlParameter param = new SqlParameter("@villainId", idToSearch);
                findMinionsCommand.Parameters.Add(param);
                reader.Close();

                SqlDataReader minionsReader = findMinionsCommand.ExecuteReader();
                int index = 1;
                while (minionsReader.Read())
                {
                    string minionName = (string)minionsReader["name"];
                    int minionAge = int.Parse(minionsReader["Age"].ToString());
                    Console.WriteLine($"{index}. {minionName} {minionAge}");
                    index++;
                }
                minionsReader.Close();
            }
            else
            {
                Console.WriteLine($"No villain with ID {idToSearch} exists in the database.");
            }
        }

        private static void GetVillainsNames(SqlConnection connection)
        {
            string query = File.ReadAllText("../../02.GetVillainsNames.sql");
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string villainName = reader["Name"].ToString();
                    int minonsCount = int.Parse(reader["MinionsCount"].ToString());

                    Console.WriteLine($"{villainName} has {minonsCount} minions.");
                }
            }
        }

        private static void CreateAndInsertTables(SqlConnection connection)
        {
            string query = File.ReadAllText(@"../../InitialSetup.sql");

            SqlCommand createTablesCommand = new SqlCommand(query, connection);
            Console.WriteLine(createTablesCommand.ExecuteNonQuery());
        }
    }
}
