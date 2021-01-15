using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Test_Class
    {
        public static void test_go_to_Definition()
        {
            NewMethod();
            parameters_check(2, 22);
        }
        static void parameters_check(int b, int a)
        {


            Console.WriteLine("");

            Console.WriteLine("");
        }

        private static void NewMethod()
        {
            Console.WriteLine("this is in test goto definition");
            Console.ReadKey();
        }
    }
}
