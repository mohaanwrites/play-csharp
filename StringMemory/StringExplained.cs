namespace play_csharp.StringMemory
{
    using BenchmarkDotNet.Attributes;
    using System.Text;

    [MemoryDiagnoser]
    public class StringExplained
    {
        [Benchmark]
        public string DoProcess_String()
        {
            string outText = string.Empty;
            for (int i = 0; i < 10000; i++)
            {
                outText += $"This is a sample text{i}";
            }
            return outText;
        }

        [Benchmark]
        public string DoProcess_StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append($"This is a sample text{i}");
            }
            return sb.ToString();
        }
    }
}