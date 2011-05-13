 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
  public class ControllerDispatchingMediatorSpecs
  {
    public abstract class concern : Observes<IProcessApplicationSpecificBehaviour,
                                      ControllerDispatchingMediator>
    {
        
    }

    public class when_run : concern
    {

      Establish c = () =>
      {
        controller_registry = depends.on<ICanFindAControllerToProcessARequest>();
        request = fake.an<IContainRequestInformation>();
      };

      Because b = () =>
        sut.run(request);


      It should_get_the_controller_details_for_the_controller_that_has_the_behaviour = () =>
        controller_registry.received(x => x.get_the_controller_that_can_handle(request));

      static ICanFindAControllerToProcessARequest controller_registry;
      static IContainRequestInformation request;
    }
  }
}
