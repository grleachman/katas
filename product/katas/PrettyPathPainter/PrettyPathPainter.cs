using System;
using System.Collections.Generic;
using System.Linq;

namespace katas.PrettyPathPainter
{
    public class PrettyPathPainter
    {
        
        public string _path_provided;
        public IEnumerable<string> _files;
        public IPathIterator _path_iterator;

        public PrettyPathPainter(string path_provided,IPathIterator pathIterator)
        {
            _path_provided = path_provided;
            _path_iterator = pathIterator;
        }
        public void traverse()
        {
            _files = _path_iterator.traverse();
        }
    }
}
