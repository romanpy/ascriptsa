using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewTheMainDepartmentsInTheStore : IProcessApplicationSpecificBehaviour
  {
    IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository;
    IDisplayReportModels reporting_engine;

    public ViewTheMainDepartmentsInTheStore() : this(new StubInformationInTheStoreCatalogRepository(),
                                                     new StubReportEngine())
    {
    }

    public ViewTheMainDepartmentsInTheStore(IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository,
                                            IDisplayReportModels reporting_engine)
    {
      this.information_in_the_store_catalog_repository = information_in_the_store_catalog_repository;
      this.reporting_engine = reporting_engine;
    }

    public void run(IContainRequestInformation request)
    {
      reporting_engine.display(information_in_the_store_catalog_repository.get_the_main_departments_in_the_store());
    }
  }
}