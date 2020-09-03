using System;
using System.Collections.Generic;
using System.Text;
using CIS501_Lab2;

namespace CIS501_Lab2
{
    public class Client
    {
        Manager m = new Manager();
        public void work()
        {           
            Helper h = m.requestHelp();
            h.doWork();
            h.finished();
            
        }
    }
}
