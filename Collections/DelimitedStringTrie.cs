using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gongchengshi.Collections.Generic;

namespace Gongchengshi.Collections
{
    public class DelimitedStringTrie : IEnumerable<string>
    {
       private readonly char _delimiter;
       private readonly Trie<string> _trie = new Trie<string>();
       private readonly string _stringDelimiter;

       public DelimitedStringTrie(char delimiter)
       {
          _delimiter = delimiter;
          _stringDelimiter = _delimiter.ToString();
       }

       public void Add(string key)
       {
          var parts = key.Split(_delimiter);
          _trie.AddSearchString(parts);
       }

       public IEnumerator<string> GetEnumerator()
       {
          return _trie.List().Select(key => string.Join(_stringDelimiter, key)).GetEnumerator();
       }

       IEnumerator IEnumerable.GetEnumerator()
       {
          return GetEnumerator();
       }
    }
}
