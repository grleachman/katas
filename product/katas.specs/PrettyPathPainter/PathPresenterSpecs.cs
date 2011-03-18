using developwithpassion.specifications.rhino;
using Machine.Specifications;

namespace katas.PrettyPathPainter.specs
{
    public class PathPresenterSpecs
    {
        //AAA
        public abstract class concern : Observes<PathPresenter>
        {
            
        }
        public class when_given_a_string : concern
        {
            private static string result;
            private static string _spacer;
            private Establish e = () =>
            {
                _spacer = "_ ";
                provide_a_basic_sut_constructor_argument(_spacer);
            };

            private Because b =
                () => result = sut.display("c:\\test\\test\\filename.txt").ToString();

            private It should_return_match_correct_tabbed_string = () => 
                result.ShouldEqual("_ _ _ filename.txt");

        }


    }
}