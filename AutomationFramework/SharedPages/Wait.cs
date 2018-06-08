using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AutomationFramework.SharedPages
{
    public class Wait
    {
        public static void WaitTime(int mileseconds)
        {
            System.Threading.Thread.Sleep(mileseconds);
        }
    }
}
