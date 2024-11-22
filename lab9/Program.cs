using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Location location = new Location(mediator);
            Timezone timezone = new Timezone(mediator);
            PrayerTimeSettings prayerTimeSettings = new PrayerTimeSettings(mediator);
            CurrentTime currentTime = new CurrentTime(mediator);
            WaqtTimesTable waqtTimesTable = new WaqtTimesTable(mediator);
            PrayerTimesTable prayerTimesTable = new PrayerTimesTable(mediator);
            CurrentWaqt currentWaqt = new CurrentWaqt(mediator);
            NextPrayer nextPrayer = new NextPrayer(mediator);

            mediator.AddDependency(location, timezone, prayerTimeSettings, currentTime, waqtTimesTable, prayerTimesTable, currentWaqt, nextPrayer);

            //currentTime.Notify();
            timezone.Update();
            Console.ReadKey();
        }
    }
}
