﻿using System;

namespace c_
{

    class Program
    {
        int method()
        {
            Console.WriteLine("inside method");
            int str = int.Parse(Console.ReadLine());
            return 1;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.method();

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                Console.WriteLine(i);

            }
        }
    }

}

