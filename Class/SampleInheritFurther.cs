using System;

namespace MasteringCSharp.Class
{
    public sealed class SampleInheritFurther : SampleInherit
    {
        public SampleInheritFurther(int id) : base(id)
        {
            ChildMessage = nameof(SampleInheritFurther);
        }

        public override void SayGreetings() => Console.WriteLine($"Hello! from {nameof(SampleInheritFurther)} | Message: {ChildMessage} | Key: {Key}");
    }
}