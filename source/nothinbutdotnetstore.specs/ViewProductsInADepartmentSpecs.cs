using System.Collections.Generic;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
  public class ViewProductsInADepartmentSpecs
  {
    public abstract class concern : Observes<IProcessApplicationSpecificBehaviour,
                                      ViewProductsInADepartment>
    {
    }

    [Subject(typeof(ViewProductsInADepartment))]
    public class when_run : concern
    {
      Establish c = () =>
      {
        request = fake.an<IContainRequestInformation>();
        var testdepartment = new DepartmentItem();

        product_repository = depends.on<IFindInformationInTheStoreCatalog>();
        report_engine = depends.on<IDisplayReportModels>();
        the_products = new List<ProductItem> {new ProductItem()};

        request.setup(x => x.map<DepartmentItem>()).Return(testdepartment);
        product_repository.setup(x => x.get_products_in(testdepartment)).Return(the_products);
      };

      Because b = () =>
        sut.run(request);

      It should_display_the_products_in_the_department = () =>
        report_engine.received(x => x.display(the_products));

      static IContainRequestInformation request;
      static IFindInformationInTheStoreCatalog product_repository;
      static IDisplayReportModels report_engine;
      static IEnumerable<ProductItem> the_products;
    }
  }
}