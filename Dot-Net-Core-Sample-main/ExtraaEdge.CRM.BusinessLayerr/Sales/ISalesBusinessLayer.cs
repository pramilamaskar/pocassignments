using ExtraaEdge.CRM.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraaEdge.CRM.BusinessLayerr
{
    public interface ISalesBusinessLayer
    {
        IEnumerable<SalesDataModel> GetSalesReport(DateTime FromDate, int ReportPeriodType);
        int Add(DateTime SALES_ORDER_DATE, string Company, double AMOUNT, double PLANNED, string CREATED_BY);
        int Update(DateTime SALES_ORDER_DATE, string Company, double AMOUNT, double PLANNED, string UPDATED_BY);
        int Remove(int SaleOrderId);
    }
}
