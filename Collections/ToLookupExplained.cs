using System.Collections.Generic;
using System.Linq;

namespace MasteringCSharp.Collections
{
    public class ToLookupExplained
    {
        public readonly List<string> _nameCollection;
        public readonly List<string> _addressCollection;
        public ToLookupExplained()
        {
            _nameCollection = new List<string>() { "Mohaan", "Harish", "Venky", "Jadeja", "Vijay" };
            _addressCollection = new List<string>() { "Trichy", "Chennai", "Chennai", "Chennai", "Chennai" };
        }

        public IEnumerable<string> DoFilter(int length) => _nameCollection.ToLookup(x => x.Length)[length];

        public IEnumerable<string> GetRange(int? start, int? end)
        {
            System.Range r1 = new System.Range(start.Value, end.Value);
            return _nameCollection.ToArray()[r1].ToList();
        }
    }
}