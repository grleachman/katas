using System.Collections.Generic;

namespace katas.PrettyPathPainter
{
    public interface IPathIterator
    {
        IEnumerable<string> traverse();
    }
}