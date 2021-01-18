using System;
using System.Collections.Generic;
using System.Text;
using ExtraaEdge.CRM.EntityModel;
using ExtraaEdge.CRM.Repositoy;


namespace ExtraaEdge.CRM.BusinessLayer.Sales
{
    public class SalesBusinessLayer : ISalesBusinessLayer
    {
        ExtraaEdgeCRMEntities dbContext = null;
        ISalesRepositoty ISalesRepositoty = null;
        public SalesBusinessLayer()
        {
            this.dbContext = new ExtraaEdgeCRMEntities();
            this.ISalesRepositoty = new SalesRepositoty(this.dbContext);
        }
        public List<SalesDataModel> GetSalesReport(DateTime FromDate, int ReportPeriodType)
        {

            
            return SalesReportRecordsList;
        }

        public void Add(SalesDataModel salesDataModel)
        {
            SALE saleObj = new SALE();
            //write a common logic to assign value from one type object to other type object in Utils class lib project.
            saleObj.ID = salesDataModel.ID;
            saleObj.SALES_ORDER_DATE = salesDataModel.SALES_ORDER_DATE;
            saleObj.Company = salesDataModel.Company;
            saleObj.AMOUNT = salesDataModel.AMOUNT;
            saleObj.PLANNED = salesDataModel.PLANNED;
            saleObj.COST = salesDataModel.COST;
            saleObj.CREATED_BY = salesDataModel.CREATED_BY;
            saleObj.CREATED_ON = salesDataModel.CREATED_ON;
            saleObj.UPDATED_BY = salesDataModel.UPDATED_BY;
            saleObj.UPDATED_ON = salesDataModel.UPDATED_ON;
            this.extraaEdgeCRMEntities.SALES.Add(saleObj);
        }
        public void Update(SalesDataModel salesDataModel)
        {
            //write a common logic to assign value from one type object to other type object in Utils class lib project.            
            SALE saleObj = this.extraaEdgeCRMEntities.SALES.Where(x => x.ID == salesDataModel.ID).FirstOrDefault();
            if (saleObj != null)
            {
                saleObj.SALES_ORDER_DATE = salesDataModel.SALES_ORDER_DATE;
                saleObj.Company = salesDataModel.Company;
                saleObj.AMOUNT = salesDataModel.AMOUNT;
                saleObj.PLANNED = salesDataModel.PLANNED;
                saleObj.COST = salesDataModel.COST;
                saleObj.CREATED_BY = salesDataModel.CREATED_BY;
                saleObj.CREATED_ON = salesDataModel.CREATED_ON;
                saleObj.UPDATED_BY = salesDataModel.UPDATED_BY;
                saleObj.UPDATED_ON = salesDataModel.UPDATED_ON;
            }
        }
        public void Remove(int SaleOrderId)
        {
            //write a common logic to assign value from one type object to other type object in Utils class lib project.            
            SALE saleObj = this.extraaEdgeCRMEntities.SALES.Where(x => x.ID == SaleOrderId).FirstOrDefault();
            if (saleObj != null)
            {
                this.extraaEdgeCRMEntities.SALES.Remove(saleObj);
            }
        }
    }
}
