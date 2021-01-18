using ExtraaEdge.CRM.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtraaEdge.CRM.BusinessLayer.Sales
{
   public interface ISalesBusinessLayer
    {
        List<SalesDataModel> GetSalesReport(DateTime FromDate, int ReportPeriodType);
        void Add(SalesDataModel salesDataModel);
        void Update(SalesDataModel salesDataModel);
        void Remove(int SaleOrderId);
    }
}
