using System;

namespace c_
{

    class Program
    {
        int method()
        {
            Console.WriteLine("inside method");
            int str = int.Parse(Console.ReadLine());
<<<<<<< HEAD
            return 2;
=======
            return 1;
>>>>>>> 07078fd2fb2e8d3e8e8098b1322c4a994c0740c0
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.method();

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    break;
                }

                Console.WriteLine(i);

            }
        }
    }

}

