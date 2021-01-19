using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate String method_str(String input);
   public class Program
    {
        public event method_str str; 
       public  method_str method;
        public Program()
        {
            str += call_me;
        }
        public static  string call_me(String input)
        {
            Console.WriteLine("this");
            return input;
        }

        
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.str("ok"));
            test_class test_ = new test_class(program);
            Console.WriteLine( program.str.Invoke("there"));            

        }

        internal void set_this(Program program)
        {
            
        }
    }
    class test_class
    {
        public test_class(Program program)
        {
            program = new Program();
            program.str += hi_there;
            program.str += Program_str;
            program.set_this(program);
        }

        private string Program_str(string input)
        {
            Console.WriteLine("in other class");
            return input;
        }

        private string hi_there(string input)
        {
            Console.WriteLine("this is being called");
            return input;
        }
    }

}
