using System.IO;
using System.Text;

namespace katas.PrettyPathPainter
{
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
            
            
            return string.Format("{0}{1}",tabs.ToString(), filename);
        }
    }
}