using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    class CustomSynchronizationContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object state)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(d));
            thread.Start(state);
            thread.Name = "MyCustomSynchronizationContextThread";            
        }
    }
}
