using System;
using System.Collections.Generic;
using System.Text;

namespace CIS_501Lab2_PT2
{
    public class Manager : Remove
    {
        private static List<Helper> active = new List<Helper>();
        public delegate void Del(Helper h);
        public Del rem = new Del(remove);

        public static void remove(Helper h)
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
