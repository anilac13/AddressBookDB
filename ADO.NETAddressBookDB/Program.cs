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
                Console.WriteLine("\nChoose option to perform \n1.Insert records to Address book \n2.Edit contact \n3.Delete contact \n4.Retrieve records belongs to City or State \n5.Count of records by City or State \n6.Retieve records alphabetically \n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
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

                        connection.Open();
                        string query = $"insert into AddressBook values('{first}','{last}','{address}','{city}','{state}','{zip}','{phone}','{email}')";
                        SqlCommand insertCommand = new SqlCommand(query, connection);
                        insertCommand.ExecuteNonQuery();
                        connection.Close();
                        break;
                    case 2:
                        connection.Open();
                        string query1 = "update AddressBook set Address='Agumbe', City='Shivamogga' where FirstName='Jeevan'";
                        SqlCommand updateCommand = new SqlCommand(query1, connection);
                        updateCommand.ExecuteNonQuery();
                        connection.Close();
                        break;
                    case 3:
                        connection.Open();
                        string query2 = "delete from AddressBook where FirstName='Jeevan'";
                        SqlCommand deleteCommand = new SqlCommand(query2, connection);
                        deleteCommand.ExecuteNonQuery();
                        connection.Close();
                        break;
                    case 4:
                        connection.Open();
                        string recordsQuery = "select * from AddressBook where City='Bengaluru' or State='Karnataka'";
                        SqlCommand retrieveCommand = new SqlCommand(recordsQuery, connection);
                        retrieveCommand.ExecuteNonQuery();
                        connection.Close();
                        break;
                    case 5:
                        connection.Open();
                        string countRecords = "select Count(*) from AddressBook group by City";
                        SqlCommand countCommand = new SqlCommand(countRecords, connection);
                        countCommand.ExecuteNonQuery();

                        string countRecords1 = "select Count(*) from AddressBook group by State";
                        SqlCommand countCommand1 = new SqlCommand(countRecords1, connection);
                        countCommand1.ExecuteNonQuery();
                        connection.Close();
                        break;
                    case 6:
                        connection.Open();
                        string orderQuery = "select * from AddressBook order by FirstName";
                        SqlCommand orderCommand = new SqlCommand(orderQuery, connection);
                        orderCommand.ExecuteNonQuery();
                        connection.Close();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}