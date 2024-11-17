using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethods PaymentMethod { get; set; }  
        public string Status { get; set; }  

        public Payment(int paymentId, decimal amount, PaymentMethods paymentMethod, string status)
        {
            PaymentId = paymentId;
            Amount = amount;
            PaymentMethod = paymentMethod;
            Status = status;
        }
    }
    internal enum PaymentStatuses 
    {
        successful, 
        failed
    }
}
