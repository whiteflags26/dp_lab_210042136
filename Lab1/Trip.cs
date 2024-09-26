using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Trip
    {
        protected PaymentMethod PreferredPayementMethod;
        public Driver Driver { get; set; }
        public abstract void PrintTripInfo();
        public Trip(Driver PaymentMethod paymentMethod)
        {
            PreferredPayementMethod = paymentMethod;
        }
    }

    public class BikeTrip : Trip
    { 
        public Rider Rider { get; set; }

        public override void PrintTripInfo()
        {
            Rider.PrintRiderInfo();
            PreferredPayementMethod.PrintPaymentInfo();
        }
    }

    public class LuxuryRide : Trip
    {
        public Rider Rider { get; set; }

        public override void PrintTripInfo()
        {
            Rider.PrintRiderInfo();
            PreferredPayementMethod.PrintPaymentInfo();
        }

    }
}
