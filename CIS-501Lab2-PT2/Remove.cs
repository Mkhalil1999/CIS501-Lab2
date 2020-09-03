using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CIS_501Lab2_PT2;

namespace CIS_501Lab2_PT2
{
    public interface Remove
    {

        public static void remove(Helper h, Manager m)
        {
            m.rem(h);
        }


    }
}
