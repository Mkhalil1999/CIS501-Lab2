using System;
using System.Collections.Generic;
using System.Text;

namespace CIS501_Lab2
{
    public class Manager
    {
        private List<Helper> active = new List<Helper>();

        public void remove(Helper h)
        {
            Console.WriteLine("Purging Helper");
            active.Remove(h);
            Console.WriteLine("...");
            Console.WriteLine("Helper Released");
        }

        public Helper requestHelp()
        {
            Console.WriteLine("Creating New Helper");
            Helper h = new Helper(this);
            active.Add(h);
            return h;
            Console.WriteLine("...");
            Console.WriteLine("Helper Created");
        }
    }
}
