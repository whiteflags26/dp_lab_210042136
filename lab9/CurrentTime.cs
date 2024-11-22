using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class CurrentTime : IWidget
    {
        public DateTime currentTime = DateTime.Now;
        
        public string id { get; set; }

        public Mediator mediator { get; set; }

        public CurrentTime(Mediator _mediator)
        {
            id = Guid.NewGuid().ToString();
            mediator = _mediator;
        }

        public void Update()
        {
            Console.WriteLine("Current Time Updated");
            Console.WriteLine("Current Time: " + currentTime);
            mediator.Notify(this.id);
        }
    }
}
