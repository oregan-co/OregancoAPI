using System;
namespace OreganCoAPI.Models
{
    public class BankTransaction
    {
        //public int TransactionId { get; set; }
        public string Concept { get; set; }
        public DateTime DateTime { get; set; }
        public double Amount { get; set; }
    }
}
