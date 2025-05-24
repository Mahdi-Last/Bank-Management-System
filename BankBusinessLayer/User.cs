using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class User : Person
    {
        public enum enMode { AddNew, Update }
        public enMode Mode;
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }

        private User(int userID,string FirstName, string LastName, string Email, string Phone, string username, string password, int permission): 
            base (userID,FirstName,LastName,Email,Phone)
        {
            
   
            Username = username;
            Password = password;
            Permission = permission;

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = UsersData.AddNewUser(this.Username, this.FirstName, this.LastName,this.Email, this.PhoneNumber, this.Password, this.Permission);

            return (UserID != -1);
        }

        private bool _UpdateUser()
        {
            return UsersData.UpdateUser(this.Username, this.FirstName, this.LastName, this.Email, this.PhoneNumber, this.Password, this.Permission);
        }

        public User(): base()
        {

            Username = "";
            Password = "";
            Permission = 0;

            Mode = enMode.AddNew;
        }

        static public User FindUserByUsername(string username)
        {
            int Permission = 0, UserID = 0;
            string FirstName = "", LastName = "", Email = "", Phone = "", Password = "";

            if (UsersData.GetUserByUsername(username, ref FirstName, ref LastName, ref Email, ref Phone, ref Password, ref Permission, ref UserID))
            {
                return new User(UserID, FirstName, LastName, Email, Phone, username, Password, Permission);
            }
            else
                return null;


        }

        static public User FindUserByUsernameAndPassword(string username, string password)
        {
            int Permission = 0, UserID = 0; 
            string FirstName = "", LastName = "", Email = "", Phone = "";

            if (UsersData.GetUserByUsernameAndPassword(username, password, ref Permission))
            {
                return new User(UserID, FirstName, LastName, Email, Phone, username, password, Permission);
            }
            else
                return null;
        }

        static public DataTable GetAllUsers()
        {
            return UsersData.GetAllUsers();
        }


        static public bool IsUserExists(string Username)
        {
            return UsersData.isUserExist( Username);
        }

        static public bool DeleteUser(string Username)
        {
            return UsersData.DeleteUser( Username);
        }

        public bool Save()
        {

            switch (Mode)
            { 
                
                case enMode.AddNew:
                    if(_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                    case enMode.Update:

                         return _UpdateUser();


            }

            return false;


        }

        public static DataTable GetAllLoginRegisters()
        {
            return LoginRegistersData.GetAllLoginRegisters();
        }

        public static int GetTotalLoginRegisters()
        {
            return LoginRegistersData.GetTotalLoginRegisters();
        }
        public static int GetTotalUsers()
        {
            return UsersData.GetTotalUsers();
        }

        public static bool AddNewLoginRegisters(string Username, DateTime date)
        {
            return LoginRegistersData.AddNewLoginRegister(Username, date) != -1;
        }
    }
}
