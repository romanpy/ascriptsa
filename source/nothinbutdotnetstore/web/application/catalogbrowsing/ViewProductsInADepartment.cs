using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewProductsInADepartment : IProcessApplicationSpecificBehaviour
  {
    IDisplayReportModels report_engine;
    IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository;

    public ViewProductsInADepartment() : this(new StubReportEngine(),
                                              new StubInformationInTheStoreCatalogRepository())
    {
    }

    public ViewProductsInADepartment(IDisplayReportModels report_engine,
                                     IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository)
    {
      this.report_engine = report_engine;
      this.information_in_the_store_catalog_repository = information_in_the_store_catalog_repository;
    }

    public void run(IContainRequestInformation request)
    {
      report_engine.display(information_in_the_store_catalog_repository.get_products_in(request.map<DepartmentItem>()));
    }
  }
}