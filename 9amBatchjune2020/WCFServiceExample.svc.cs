using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _9amBatchjune2020
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFServiceExample" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFServiceExample.svc or WCFServiceExample.svc.cs at the Solution Explorer and start debugging.
    public class WCFServiceExample : IWCFServiceExample
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public void DoWork()
        {
        }
    }
}
