using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class UsersData
    {

        public static bool GetUserByID( int UserID, ref string firstName, ref string lastName, ref string email, ref string phoneNumber,ref string Username, ref string Password, ref int Permission)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select FirstName, LastName, Email, Phone, Username, Password, Permission
                            from Users
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    
                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phoneNumber = (string)reader["Phone"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
                 

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetUserByUsername(string Username, ref string firstName, ref string lastName, ref string email, ref string phoneNumber, ref string Password, ref int Permission, ref int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select FirstName, LastName, Email, Phone, Username, Password, Permission
                            from Users
                            where Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    
                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phoneNumber = (string)reader["Phone"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
                    UserID = (int)reader["UserID"];

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetUserByUsernameAndPassword(string Username, string Password, ref int Permission)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from Users where Username = @Username AND Password = @Password";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;
                    Permission = (int)Reader["Permission"];
                  
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool DeleteUser(string Username)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from Users
                            where Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {

                connection.Open();

                RowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.ToString());
            }

            finally
            {

                connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool UpdateUser(string Username, string firstName, string lastName, string email, string phoneNumber, string Password, int Permission)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Users
                            Set 
                                FirstName = @FirstName,
                                 LastName = @LastName,
                                 Email = @Email,
                                 Phone = @Phone,
	                            Permission = @Permission,
	                            Password = @Password
	                            where (Username = @Username)
                            ";

            SqlCommand Command = new SqlCommand(query, connection);

      
            Command.Parameters.AddWithValue("@FirstName", firstName);
            Command.Parameters.AddWithValue("@LastName", lastName);
            Command.Parameters.AddWithValue("@Email", email);
            Command.Parameters.AddWithValue("@Phone", phoneNumber);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Permission", Permission);
            Command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                RowsAffected = Command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                connection.Close();


            }

            return RowsAffected > 0;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select FirstName, LastName, Email, Phone , Username, Password, Permission from Users
                          ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool isUserExist(string Username)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select Found = 1 from Users
                                Where (Username = @Username)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                isFound = reader.HasRows;


                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return isFound;


        }

        public static int AddNewUser(string Username, string FirstName, string LastName, string Email , string Phone, string Password, int Permission)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"
                            Insert into Users(FirstName, LastName, Email, Phone, Username, Password, Permission)
                            Values (@FirstName, @LastName, @Email, @Phone,@Username,@Password,@Permission);
                            Select Scope_IDENTITY()";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permission", Permission);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    UserID = insertedID;
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static int GetTotalUsers()
        {
            int totalUsers = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select Count(Users.UserID) from Users";

            SqlCommand Command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedTotalUsers))
                {
                    totalUsers = InsertedTotalUsers;
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            finally
            {
                connection.Close();
            }

            return totalUsers;
        }

    }
}
