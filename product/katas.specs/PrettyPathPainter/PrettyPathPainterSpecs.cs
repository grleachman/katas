using System;
using System.Linq;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhino;
using developwithpassion.specifications;
using Machine.Specifications;
using Rhino.Mocks;
using System.IO;

namespace katas.PrettyPathPainter.specs
{
    
    public class PrettyPathPainterSpecs 
    {
        
        public abstract class concern : Observes<PrettyPathPainter>
        {
            
        }

        public class when_class_instantiated: concern
        {
            private Establish b = () =>
            {
                provide_a_basic_sut_constructor_argument("c:/gareth");
            };

            private It should_have_path_set = () => sut._path_provided.Equals("c:/gareth");

        }
        public class when_reading_from_dummy_filelist_FileListing1_dot_txt : concern
        {
            private static string _path;
            private static string[] _files;
            private static IPathIterator _path_iterator;
            private static IPathPresenter _path_presenter;

            //Arrange
            private Establish e = () =>
                                      {
                                          _path_iterator = the_dependency<IPathIterator>();
                                          _path_presenter = the_dependency<IPathPresenter>();
                                          _path = "c:/";
                                          provide_a_basic_sut_constructor_argument(_path);
                                          _files = File.OpenText("./../product/katas.specs/PrettyPathPainter/FileListing1.txt").ReadToEnd().Split('\n');
                                          _path_iterator.setup(x => x.traverse()).Return(_files);
                                      };
            //Act
            private Because b = () => sut.traverse();
                                    
            //Assert                
            private It should_have_six_files = () => sut._files.Length.Equals(6);

            private It should_have_been_traversed = () => _path_iterator.AssertWasCalled(x => x.traverse());

        }
    }

   

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

            private It should_return_match_correct_tabbed_string = () => result.ShouldEqual("_ _ _ filename.txt");

        }


    }

}
