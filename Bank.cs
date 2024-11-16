using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppUI
{
    
        internal class Bank
        {
            private int count;
            private string sort_code;
            
            private BankAccount[] accounts;
            public Bank(string sort_code, int max_accounts)
            {
                count = 0;
                this.sort_code = sort_code;
                accounts = new BankAccount[max_accounts];

            }
            public int CreateAccount(string forename, string surname, string address)
            {
                accounts[count] = new BankAccount(forename, surname, address);
                count++;
                return count - 1;

            }
            public string GetDetails(int acc_no)
            {
                return accounts[acc_no].GetDetails();
            }
        }
}
