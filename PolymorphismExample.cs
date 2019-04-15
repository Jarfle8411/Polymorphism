using System;

            /*
             Polymorphism example
             * uses the same methods but have different ways of starting and stopping            
             */

namespace Polymorph
{
    class Program
    {
        public interface InterfaceDemo
        {
            bool start();
            bool stop();
        }
        static void Main(string[] args)
        {
            //Declaring Objects
            var car = new car();
            var mower = new lawnmower();
            var Airplane = new airplane();

            // Methods calling classes
            stop(car);
            start(mower);
            start(Airplane);

            Console.Read();
        }
        // creating a start method which uses Interface InterfaceDemo like an datatype
        // to allow functionality of the start and stop methods to be used.
        static void start(InterfaceDemo m)
        {
            //logging
            m.start();
        }
        static void stop(InterfaceDemo s)
        {
            //logging
            s.stop();
        }
            // Class Car inheriting from the Interface Demo Interface
        class car : InterfaceDemo
        {
            // creating public bool start and stop methods with no which returns true
            public bool start()
            {
                Console.WriteLine(" Car Started!");
                return true;
            }
            public bool stop()
            {
                Console.WriteLine(" Car Stopped!");
                return true;
            }
        }
        // Class Lawnmower inheriting from the Interface Demo Interface
        class lawnmower : InterfaceDemo
        {
            // creating public bool start and stop methods with no which returns true
           public bool start()
           {
               Console.WriteLine(" Lawnmower Started!");
               return true;
           }
           public bool stop()
           {
               Console.WriteLine(" Lawnmower Stopped!");
               return true;
           }
        }
        // Class Airplane inheriting from the Interface Demo Interface
         class airplane : InterfaceDemo
        {
            // creating public bool start and stop methods with no which returns true
            public bool start()
            {
                Console.WriteLine(" Airplane Started!");
                return true;
            }
            public bool stop()
            {
                Console.WriteLine(" Airplane Stopped!");
                return true;
            }
        }
    }
}