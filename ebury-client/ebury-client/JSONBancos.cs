using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebury_client
{
    class JSONBancos
    {
        public string productNumber, balance, status, productType;
        public List<accountHolder> accountHolder;
        
        public JSONBancos(string productNumber, string balance, string status, string productType)
        {
            this.productNumber = productNumber;
            this.balance = balance;
            this.status = status;
            this.productType = productType;
            accountHolder = new List<accountHolder>();
        }
        public override string ToString()
        {
            return "(" + productNumber + ", " + balance + ", " + status + ", " + productType + ", [" +
                string.Join<accountHolder>(", ", accountHolder) + "])";
        }
    }
}