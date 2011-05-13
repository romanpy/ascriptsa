namespace nothinbutdotnetstore.web.core
{
  public interface ICanFindAControllerToProcessARequest 
  {
    void get_the_controller_that_can_handle(IContainRequestInformation request);
  }
}