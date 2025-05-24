using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class TransferLogs
    {
        public int ID { get; set; }
        public string AccountForom {  get; set; }
        public string AccountTo { get; set; }
        public decimal Amount { get; set; }
        
        public string PerformedBy {  get; set; }

        public DateTime Date { get; set; }

        public TransferLogs()
        {
            ID = -1;
            AccountForom = "";
            AccountTo = "";
            Amount = 0;
            PerformedBy = "";
        }
        public static DataTable GetAllTransferLogs()
        {
            return TransferLogsData.GetAllTransferLogs();
        }

        public bool AddTrnasferLog()
        {
            ID = TransferLogsData.AddNewTransferLog(this.Date, this.AccountForom, this.AccountTo, this.Amount, this.PerformedBy);

            return (ID != -1);
        }

        public static int GetTotalTransferLogs()
        {
            return TransferLogsData.GetTotalTransferLogs();
        }
    }
}
