using System.Collections.Generic;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
  public class ViewTheMainDepartmentsInTheStoreSpecs
  {
    public abstract class concern : Observes<IProcessApplicationSpecificBehaviour,
                                      ViewTheMainDepartmentsInTheStore>
    {
    }

    public class when_run : concern
    {
      Establish c = () =>
      {
         view = depends.on<IView>();
         datapackage = fake.an<IEnumerable<string>>();
         datastore = depends.on<IDataStore>();
         request = fake.an<IContainRequestInformation>();
      };

        Because b = () =>
        sut.run(request);


      It should_invoke_the_data_store = () =>
      {
          datastore.received(x => x.GetData(sut));
      };

    It should_invoke_view = () =>
    {
        view.received(x => x.ShowData(datapackage));
    };


        static IContainRequestInformation request;
        static IDataStore datastore;
        static IEnumerable<string> datapackage;
        static IView view;
    }
  }

    interface IDataStore
    {
        IEnumerable<string> GetData(IProcessApplicationSpecificBehaviour info);
    }

    interface IView
    {
        void ShowData(IEnumerable<string> data) ;
    }

}