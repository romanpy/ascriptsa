using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.web.application.stubs
{
  public class StubInformationInTheStoreCatalogRepository : IFindInformationInTheStoreCatalog
  {
    public IEnumerable<DepartmentItem> get_the_main_departments_in_the_store()
    {
      return Enumerable.Range(1, 100).Select(x => new DepartmentItem {name = x.ToString("Department 0")});
    }

    public IEnumerable<DepartmentItem> get_departments_in(DepartmentItem selected_department)
    {
      return Enumerable.Range(1, 100).Select(x => new DepartmentItem {name = x.ToString("Sub Department 0")});
    }

    public IEnumerable<ProductItem> get_products_in(DepartmentItem testdepartment)
    {
      return Enumerable.Range(1, 100).Select(x => new ProductItem {name = x.ToString("Product 0")});
    }
  }
}