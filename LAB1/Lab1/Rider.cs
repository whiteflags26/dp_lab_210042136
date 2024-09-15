using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Rider
    {
        public string Name { get; set; }
        private string _id { get; set; }
        private string _location { get; set; }
        public decimal Rating { get; set; }
        public PaymentMethod PreferredPayementMethod { get; set; }


        public void BookRide(Driver driver)
        {
            MakePayment();
            RateDriver(driver);
        }
        public void MakePayment()
        {
            PreferredPayementMethod.Payment();
        }
        public void RateDriver(Driver driver)
        {

        }
    }
}
