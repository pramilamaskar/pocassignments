using ExtraaEdge.CRM.BusinessLayerr;

using ExtraaEdge.CRM.EntityModel;
using ExtraaEdge.CRM.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraaEdge.CRM.BusinessLayer
{
    public class SalesBusinessLayer : ISalesBusinessLayer
    {       
        ISalesRepositoty ISalesRepositoty = null;
        public SalesBusinessLayer()
        {           
            this.ISalesRepositoty = new SalesRepositoty();
        }
        public IEnumerable<SalesDataModel> GetSalesReport(DateTime FromDate, int ReportPeriodType)
        {
           return ISalesRepositoty.GetSalesReport(FromDate, ReportPeriodType);            
        }

        public int  Add(DateTime SALES_ORDER_DATE, string Company, double AMOUNT, double PLANNED, string CREATED_BY)
        {
            SalesDataModel salesDataModel = new SalesDataModel();
            salesDataModel.SALES_ORDER_DATE = SALES_ORDER_DATE;
            salesDataModel.Company = Company;
            salesDataModel.AMOUNT = AMOUNT;
            salesDataModel.PLANNED = PLANNED; 
            salesDataModel.CREATED_BY = CREATED_BY;
            salesDataModel.CREATED_ON = DateTime.Now;
            salesDataModel.UPDATED_BY = CREATED_BY;
            salesDataModel.UPDATED_ON = DateTime.Now;
            return ISalesRepositoty.Add(salesDataModel);
        }
        public int Update(DateTime SALES_ORDER_DATE, string Company, double AMOUNT, double PLANNED, string UPDATED_BY)
        {
            SalesDataModel salesDataModel = new SalesDataModel();
            salesDataModel.SALES_ORDER_DATE = SALES_ORDER_DATE;
            salesDataModel.Company = Company;
            salesDataModel.AMOUNT = AMOUNT;
            salesDataModel.PLANNED = PLANNED;            
            salesDataModel.UPDATED_BY = UPDATED_BY;
            salesDataModel.UPDATED_ON = DateTime.Now;
            return ISalesRepositoty.Update(salesDataModel);
        }
        public int Remove(int SaleOrderId)
        {
            return ISalesRepositoty.Remove(SaleOrderId);
        }
    }
}
