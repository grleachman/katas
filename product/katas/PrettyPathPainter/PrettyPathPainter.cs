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
    public interface IPathPresenter
    {
        string display(string PathFile);
    }
    public class PathPresenter : IPathPresenter
    {
        string _spacer;
        public PathPresenter(string spacer)
        {
            _spacer = spacer;
        }
        public string display(string PathFile)
        {
            string filename = Path.GetFileName(PathFile);
            int tabCount = PathFile.Split(Path.DirectorySeparatorChar).Length - 1;
            
            StringBuilder tabs = new StringBuilder();
            for (int i = 0; i < tabCount; i++)
            {
                tabs.Append(_spacer);
            }
            //Enumerable.Range(1, tabCount).Select(x => tabs.Append(_spacer));
            
            return string.Format("{0}{1}",tabs.ToString(), filename);
        }
    }
}
