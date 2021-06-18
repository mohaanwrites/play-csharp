using System;

namespace MasteringCSharp.Class
{
    public class SampleBase
    {
        private protected string ChildMessage;

        public int Id { get; init; }

        public Guid Identifier { get; set; } = Guid.NewGuid();

        public SampleBase(int id)
        {
            Id = id;
            ChildMessage = nameof(SampleBase);
        }

        public virtual string Key => "Key";
        public virtual void DisplayId() => Console.WriteLine($"From Base:\n Id = {Id} | Identifier = {Identifier} | Message: {ChildMessage} | Key: {Key}");

        public virtual void SayGreetings() => Console.WriteLine($"Hello! from Base");
    }
}