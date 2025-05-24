using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace BankDataAccessLayer
{
    public class TransferLogsData
    {

        public static DataTable GetAllTransferLogs()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select Date, FromAccount, ToAccount, Amount, PerformedBy from TransferLogs";

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

        public static int AddNewTransferLog(DateTime Date, string FromAccountNumber, string ToAccountNumber, decimal Amount, string PerformedBy)
        {
            int TransferLogID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert Into TransferLogs (Date, FromAccount, ToAccount,Amount, PerformedBy)
                            Values(@Date, @FromAccountNumber, @ToAccountNumber, @Amount , @PerformedBy)";

            SqlCommand Command = new SqlCommand(query, connection);


            Command.Parameters.AddWithValue("@Date", Date);
            Command.Parameters.AddWithValue("@FromAccountNumber", FromAccountNumber);
            Command.Parameters.AddWithValue("@ToAccountNumber", ToAccountNumber);
            Command.Parameters.AddWithValue("@Amount", Amount);
            Command.Parameters.AddWithValue("@PerformedBy", PerformedBy);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {

                    TransferLogID = insertedID;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return TransferLogID;

        }

        public static int GetTotalTransferLogs()
        {
            int totalTransferLogs = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select Count(TransferLogs.TransferID) from TransferLogs
          ";

            SqlCommand Command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedTotalTransferLogs))
                {
                    totalTransferLogs = InsertedTotalTransferLogs;
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            finally
            {
                connection.Close();
            }

            return totalTransferLogs;
        }

    }
}
