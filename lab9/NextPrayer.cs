using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class NextPrayer : IWidget
    {
        public string nextPrayer { get; set; }
        public string id { get; set; }
        public Mediator mediator { get; set; }

        public NextPrayer(Mediator mediator)
        {
            id = Guid.NewGuid().ToString();
            this.mediator = mediator;
        }

        public void Update()
        {
            Console.WriteLine("Next Prayer Updated");
            mediator.Notify(this.id);
        }
    }
}
