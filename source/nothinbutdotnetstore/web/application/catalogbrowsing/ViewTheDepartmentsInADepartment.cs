using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class ViewTheDepartmentsInADepartment : IProcessApplicationSpecificBehaviour
  {
    IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository;
    IDisplayReportModels report_engine;

    public ViewTheDepartmentsInADepartment():this(new StubInformationInTheStoreCatalogRepository(),
      new StubReportEngine())
    {
    }

    public ViewTheDepartmentsInADepartment(IFindInformationInTheStoreCatalog information_in_the_store_catalog_repository, IDisplayReportModels report_engine)
    {
      this.information_in_the_store_catalog_repository = information_in_the_store_catalog_repository;
      this.report_engine = report_engine;
    }

    public void run(IContainRequestInformation request)
    {
      report_engine.display(information_in_the_store_catalog_repository.get_departments_in(request.map<DepartmentItem>()));
    }
  }
}