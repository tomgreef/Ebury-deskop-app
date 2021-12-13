using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebury_client
{
    class JSONBancos
    {
        public string accountNumber, balance, accountState, accountType;
        public List<Particular> particulares;
        
        public JSONBancos(string accountNumber, string balance, string accountState, string accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountState = accountState;
            this.accountType = accountType;
            particulares = new List<Particular>();
        }
        public override string ToString()
        {
            return "(" + accountNumber + ", " + balance + ", " + accountState + ", " + accountType + ", [" +
                string.Join<Particular>(", ", particulares) + "])";
        }
    }
}