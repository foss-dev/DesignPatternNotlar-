﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Console.WriteLine(s1.id.ToString());

            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine(s2.id.ToString());
        }
    }
}
