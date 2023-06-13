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
                        connection.Open();
                        Console.WriteLine("Enter first name");
                        string first = Console.ReadLine();
                        Console.WriteLine("Enter last name");
                        string last = Console.ReadLine();
                        Console.WriteLine("Enter address");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter city");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter state");
                        string state = Console.ReadLine();
                        Console.WriteLine("Enter zip code");
                        string zip = Console.ReadLine();
                        Console.WriteLine("Enter phone number");
                        string phone = Console.ReadLine();
                        Console.WriteLine("Enter email");
                        string email = Console.ReadLine();

                        string query = $"insert into AddressBook values('{first}','{last}','{address}','{city}','{state}','{zip}','{phone}','{email}')";
                        SqlCommand insertCommand = new SqlCommand(query, connection);
                        insertCommand.ExecuteNonQuery();
                        connection.Close();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}