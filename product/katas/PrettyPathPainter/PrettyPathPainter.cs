using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace katas.PrettyPathPainter
{
    public class PrettyPathPainter
    {
        
        public string _path_provided;
        public string[] _files;
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

    public interface IPathIterator
    {
        string[] traverse();
    }

    public class PathIterator : IPathIterator
    {
        public string[] traverse()
        {
            return null;
        }
    }
}
