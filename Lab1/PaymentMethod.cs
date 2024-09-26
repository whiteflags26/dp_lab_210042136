using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class PaymentMethod
    {
        protected decimal _amount;

        public PaymentMethod()
        {
            _amount = CalculatePayment();
        }

        public abstract decimal CalculatePayment();
        public abstract void PrintPaymentInfo();
    }

    public class BkashPayment : PaymentMethod
    {
        public BkashPayment(decimal amount) : base()
        {
        }

        public override decimal CalculatePayment()
        {
            return 1;
        }

        public override void PrintPaymentInfo()
        {
            Console.WriteLine("Bkash Payment");
            Console.WriteLine($"Payment Amount: {_amount}");
        }
    }

    public class CashPayment : PaymentMethod
    {
        public CashPayment(decimal amount) : base()
        {
        }

        public override decimal CalculatePayment()
        {
            return -1;
        }

        public override void PrintPaymentInfo()
        {
            Console.WriteLine("Cash Payment");
            Console.WriteLine($"Payment Amount: {_amount}");
        }
    }
}
