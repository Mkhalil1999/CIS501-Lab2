using System;
using System.Collections.Generic;
using System.Text;

namespace CIS501_Lab2
{
    public class Helper
    {
        public Manager myManager;
        public void doWork()
        {
            Console.WriteLine("Doing work...");
        }

        public void finished()
        {
            Console.WriteLine("Helper work is done...");
            myManager.remove(this);
        }

        public Helper(Manager myManager)
        {
            this.myManager = myManager;
        }
    }
}
