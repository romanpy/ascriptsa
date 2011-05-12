using System;

namespace nothinbutdotnetstore.web.core
{
  public class ProcessOneUniqueRequest : IProcessOneUniqueRequest
  {
    public void run(IContainRequestInformation request)
    {
      throw new NotImplementedException();
    }

    public bool can_handle(IContainRequestInformation request)
    {
        if (request.Identity == 0)
            return false;
        else return true;
    }
  }
}