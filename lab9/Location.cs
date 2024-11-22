using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Location : IWidget
    {
        public string location { get; set; }
        public string id { get; set; }
        public Mediator mediator { get; set; }

        public Location(Mediator mediator)
        {
            id = Guid.NewGuid().ToString();
            this.mediator = mediator;
        }

        public void Update()
        {
            Console.WriteLine("Location Updated");
            mediator.Notify(this.id);   
        }
    }
}
