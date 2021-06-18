using System;

namespace MasteringCSharp.Class
{
    public class SampleInherit : SampleBase
    {
        private protected SampleHelper GetHelperInstance()
        {
            return new SampleHelper();
        }

        public SampleInherit(int id) : base(id)
        {
            ChildMessage = nameof(SampleInherit);
        }
        public sealed override void DisplayId()
        {
            GetHelperInstance().DoSomething();
            Console.WriteLine($"From {nameof(SampleInherit)}:\n Id = {Id} | Identifier = {Identifier} | Message: {ChildMessage}");
        }
        public override void SayGreetings() => Console.WriteLine($"Hello! from {nameof(SampleInherit)}");
    }
}