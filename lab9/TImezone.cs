using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Timezone : IWidget
    {
        public string timezone { get; set; }
        public string id { get; set; }
        public Mediator mediator { get; set; }

        public Timezone(Mediator mediator)
        {
            id = Guid.NewGuid().ToString();
            this.mediator = mediator;
        }

        public void Update()
        {
            Console.WriteLine("Timezone Updated");
            mediator.Notify(this.id);

        }
    }
}
