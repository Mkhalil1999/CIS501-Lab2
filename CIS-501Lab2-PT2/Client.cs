using System;
using System.Collections.Generic;
using System.Text;

namespace CIS_501Lab2_PT2
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
