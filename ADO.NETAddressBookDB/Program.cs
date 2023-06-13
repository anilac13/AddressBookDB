using System;
using System.Data.SqlClient;

namespace ADO.NETAddressBookDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Database = AddressBookDB; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
        }
    }
}