using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class CurrentWaqt : IWidget
    {
        public string currentWaqt{ get; set; }

        public string id{get; set;}

        public Mediator mediator { get; set; }

        public CurrentWaqt(Mediator mediator)
        {
            id = Guid.NewGuid().ToString();
            this.mediator = mediator;
        }

        public void Update()
        {
            Console.WriteLine("Current Waqt Updated");
            mediator.Notify(this.id);
        }
    }
}
