using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class PrayerTimesTable : IWidget
    {
        public string prayerTimesTable { get; set; }
        public string id { get; set; }
        public Mediator mediator { get; set; }

        public PrayerTimesTable(Mediator mediator)
        {
            id = Guid.NewGuid().ToString();
            this.mediator = mediator;
        }

        public void Update()
        {
            Console.WriteLine("Prayer Times Table Updated");
            mediator.Notify(this.id);
        }
    }
}
