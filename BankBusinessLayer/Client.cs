using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class Client : Person
    {

        public enum enMode { Update, AddNew };

        public enMode Mode;


        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public decimal Balance { get; set; }

        private Client(int ClientID, string firstName, string lastName, string email, string phoneNumber ,string AccountNumber, string PinCode, decimal Balance)
        : base(ClientID, firstName,lastName,email,phoneNumber)

        { 
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.Balance = Balance;
            this.ClientID = ClientID;

            Mode = enMode.Update;
        }

        private bool _AddNewClient()
        {
            this.ClientID = ClientsData.AddNewClient(this.FirstName, this.LastName , this.Email, this.PhoneNumber, this.AccountNumber, this.PinCode,this.Balance);

            return (ClientID != -1);
        }

        private bool _UpdateClient()
        {
            return ClientsData.UpdateClient(this.FirstName, this.LastName, this.Email, this.PhoneNumber, this.AccountNumber, this.PinCode, this.Balance);
        }
        public Client() 
        {
            this.AccountNumber = "";
            this.PinCode = "";
            this.Balance = 0;
            this.ClientID = -1;

            Mode = enMode.AddNew;
        }

        static public Client Find(string AccountNumber)
        {
            int ClientID = 0;
            string FirstName = "", LastName = "", Email = "", PhoneNumber = "", PinCode = "";
            decimal Balance = 0;


            if (ClientsData.GetClientInfoByAccountNumber(AccountNumber,ref FirstName, ref LastName, ref Email, ref PhoneNumber , ref PinCode, ref Balance, ref ClientID))
            {

                return new Client(ClientID,FirstName,LastName, Email, PhoneNumber, AccountNumber,PinCode, Balance);
            }
            else
                return null;
            
            
        }

        static public Client Find(int ClientID)
        {
            
            string FirstName = "", LastName = "", Email = "", PhoneNumber = "", PinCode = "", AccountNumber = "";
            decimal Balance = 0;


            if (ClientsData.GetClientInfoByClinetID(ClientID, ref AccountNumber, ref FirstName, ref LastName, ref Email, ref PhoneNumber, ref PinCode, ref Balance))
            {

                return new Client(ClientID, FirstName, LastName, Email, PhoneNumber, AccountNumber, PinCode, Balance);
            }
            else
                return null;


        }

       

        public  static  DataTable GetAllClients()
        {
            return ClientsData.GetAllClients();
        }

       static public bool DeleteClient(int ID)
        {
            return ClientsData.DeleteClientByID(ID);
        }

        static public bool DeleteClient(string AccountNumber)
        {
            return ClientsData.DeleteClientByAccountNumber(AccountNumber);
        }

        static public bool IsClientExist(string AccNumber)
        {
            return ClientsData.isClientExist(AccNumber);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew: 
                    if(_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                 
                case enMode.Update:

                    return _UpdateClient();
                    
            }

            return false;

        }


        public static bool Deposit(string AccountNumber, decimal Amount)
        {
            if(Amount < 0)
                return false;

            return ClientsData.Deposit(AccountNumber, Amount);

        }

        public static bool Withdraw(string AccountNumber, decimal balance, decimal Amount)
        {
            

            if (Amount <= 0 || Amount > balance)
                return false;

            return ClientsData.Withdraw(AccountNumber, Amount);

        }

        public static DataTable GetAllBalances()
        {
            return ClientsData.GetAllBalances();
        }

        public bool Transfer(string AccountFrom, string AccountTo, decimal Amount)
        {
            if(Amount <= 0 || Amount > Balance)
            {
                return false;
            }

            return ClientsData.Transfer(AccountFrom, AccountTo, Amount);
        }

        public static int GetTotalClients()
        {
            return ClientsData.GetTotalClients();
        }

        public static decimal GetTotalBalances()
        {
            return ClientsData.GetTotalBalances();
        }


    }
}
