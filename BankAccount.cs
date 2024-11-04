using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppUI
{
    internal class BankAccount
    {

        private string forename;
        private string surname;
        private string address;
        private double balance;
        //private int acc_no;
        public BankAccount(string forename, string surname, string address)
        {
            balance = 0;
            this.forename = forename;
            this.address = address;
            this.surname = surname;
        }
        public string GetDetails()
        {
            return forename + " " + surname + " " + address + " " + balance;
        }
    }
}
