namespace play_csharp.StringMemory
{
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class StringExplained
    {
        [Benchmark]
        public void DoProcess()
        {
            for (int i = 0; i < 10000; i++)
            {
                var outText = $"This is a sample text{i}";
            }
        }
    }
}