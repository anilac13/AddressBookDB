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

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Insert records to Address book \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        
                        break;
                }
            }
        }
    }
}