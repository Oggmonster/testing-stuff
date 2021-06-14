using Dapper;
using Npgsql;
using System.Collections.Generic;
namespace testing_stuff
{
    public class DB
    {
        private static string connectionStr = "User ID=tester;Password=test123;Host=localhost;Port=5432;Database=tutorial;";
        public static List<string> ReadSomething()
        {
            using (var connection = new NpgsqlConnection(connectionStr))
            {
                var locations = connection.Query<string>("SELECT location FROM conditions");
                return locations.AsList();
            }
        }
    }
}
