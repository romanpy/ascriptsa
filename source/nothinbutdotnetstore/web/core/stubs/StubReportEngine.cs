using System.Collections.Generic;
using System.Web;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.web.core.stubs
{
  public class StubReportEngine : IDisplayReportModels
  {
    public void display<ReportModel>(ReportModel model)
    {
      HttpContext.Current.Items.Add("blah", model);
      if (typeof(ReportModel) == typeof(IEnumerable<DepartmentItem>))
      {
        transer_to_view("DepartmentBrowser");
        return;
      }

      transer_to_view("ProductBrowser");
    }

    void transer_to_view(string view_name)
    {
      HttpContext.Current.Server.Transfer(string.Format("~/views/{0}.aspx", view_name));
    }
  }
}