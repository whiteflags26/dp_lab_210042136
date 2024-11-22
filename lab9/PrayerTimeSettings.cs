using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class PrayerTimeSettings : IWidget
    {
        public string prayerTimeSettings { get; set; }
        public string id { get; set; }
        public Mediator mediator { get; set; }

        public PrayerTimeSettings(Mediator mediator)
        {
            id = Guid.NewGuid().ToString();
            this.mediator = mediator;
        }

        public void Update()
        {
            Console.WriteLine("Prayer Time Settings Updated");
            mediator.Notify(this.id);
        }
    }
}
