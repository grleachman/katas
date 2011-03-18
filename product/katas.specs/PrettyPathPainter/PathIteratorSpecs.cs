using developwithpassion.specifications.rhino;
using Machine.Specifications;

namespace katas.PrettyPathPainter.specs
{
    public class PathIteratorSpecs
    {
        public abstract   class concern : Observes<PathIterator>{}

        public class when_traverse_is_called
        {
            It should_iterate_over_the_folder = () => { };
        }
    }
}