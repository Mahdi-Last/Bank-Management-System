using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class LoginRegistersData
    {

        public static DataTable GetAllLoginRegisters()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select Date, Username,Password, Permission from LoginRegisters
                                Join Users on LoginRegisters.UserID = Users.UserID";

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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static int  AddNewLoginRegister(string Username, DateTime Date)
        {
            int LoginRegisterID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"declare @ID int ;

                            set @ID = (Select Users.UserID from Users Where Username = @Username);

                            insert into LoginRegisters (Date, UserID)
                            Values(@Date, @ID);
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Date", Date);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LoginRegisterID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            { connection.Close(); }

            return LoginRegisterID;
        }


        public static int GetTotalLoginRegisters()
        {
            int totalLoginRegisters = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select Count(LoginRegisters.LoginID) from LoginRegisters
          
          ";

            SqlCommand Command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedTotalLoginRegisters))
                {
                    totalLoginRegisters = InsertedTotalLoginRegisters;
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            finally
            {
                connection.Close();
            }

            return totalLoginRegisters;
        }
    }
}
