using ExtraaEdge.CRM.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraaEdge.CRM.Repositoy
{
  public interface ISalesRepositoty
    {
        IEnumerable<SalesDataModel> GetSalesReport(DateTime FromDate, int ReportPeriodType);
        int Add(SalesDataModel salesDataModel);      
        int Update(SalesDataModel salesDataModel);       
        int Remove(int SaleOrderId);       
    }
}
