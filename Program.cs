﻿    using System;

namespace test_val_ref_static
{
    class Program
    {
        static void Main(string[] args)


        {
            Base test = new Base();
            test.First();
            test.Second();
            Console.WriteLine("-=-=-");

            Derived test2 = new Derived();
            test2.First();
            test2.Second();
            Console.WriteLine("-=-=-");

            Base derivedAsBase = new Derived();
            derivedAsBase.BBB();

            derivedAsBase.First();  // Derived.First(), выведет "First from Derived"           	 
            derivedAsBase.Second(); // Base.Second(), выведет "Second from Base"
            Console.ReadLine();
        }

        class Base
        {
            public virtual void First()
            {
                Console.WriteLine("First from Base");
            }

            public virtual void Second()
            {
                Console.WriteLine("Second from Base");
            }
            public void BBB()
            {
                Console.WriteLine("BBB");
            }
        }
        class Derived : Base
        {
            public override void First()
            {
                Console.WriteLine("First from Derived");
            }
            public new void Second()
            {
                Console.WriteLine("Second from Derived");
            }
            public void DDD()
            {
                Console.WriteLine("ddd");
            }

        }
    }
}


