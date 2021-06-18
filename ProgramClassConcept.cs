using System;
using MasteringCSharp.Class;

namespace MasteringCSharp
{
    partial class Program
    {
        private static void OutputClassConcepts()
        {
            //Create object for base class SampleBase
            SampleBase sb1 = new SampleBase(10);
            sb1.DisplayId();
            sb1.SayGreetings();

            //Create object reference for base class SampleBase from SampleInherit
            SampleBase s1 = new SampleInherit(10);
            s1.DisplayId();
            s1.SayGreetings();

            //Create object for SampleInheritFurther class
            SampleInheritFurther sif = new SampleInheritFurther(10);
            sif.DisplayId();
            sif.SayGreetings();

            //You cannot change Id whereas you can change Identifier
            //sif.Id = 100; => Init Only Property
            sif.Identifier = Guid.NewGuid();

            Console.WriteLine($"Back to Program.cs");
        }
    }
}