using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class WaqtTimesTable : IWidget
    {
        public List<string> WaqtTimes { get; set; }

        public string id { get; set; }

        public Mediator mediator { get; set; }

        public WaqtTimesTable(Mediator mediator)
        {
            id = Guid.NewGuid().ToString();
            this.mediator = mediator;
        }

        public void Update()
        {
            Console.WriteLine("Waqt Times Table Updated");
            mediator.Notify(this.id);
        }
    }
}
