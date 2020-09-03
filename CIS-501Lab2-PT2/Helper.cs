using System;
using System.Collections.Generic;
using System.Text;

namespace CIS_501Lab2_PT2
{
    public class Helper
    {
        private Remove done;
        public Manager myManager;
        public void doWork()
        {
            Console.WriteLine("Doing work...");
        }

        public void finished()
        {
            Console.WriteLine("Helper work is done...");
            Remove.remove(this, myManager);
            
        }

        public Helper(Remove done)
        {
            done(this.myManager);
        }
    }
}
