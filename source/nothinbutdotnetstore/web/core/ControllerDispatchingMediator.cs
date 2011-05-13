using System;

namespace nothinbutdotnetstore.web.core
{
  public class ControllerDispatchingMediator : IProcessApplicationSpecificBehaviour
  {
    public ControllerDispatchingMediator(ICanFindAControllerToProcessARequest registry)
    {
        this.registry = registry;
    }

    private ICanFindAControllerToProcessARequest registry;

    public void run(IContainRequestInformation request)
    {
        registry.get_the_controller_that_can_handle(request);
    }
  }
}