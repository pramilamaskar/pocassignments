using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtraaEdge.CRM.Common.Utils.Enums;
using ExtraaEdge.CRM.EntityModel;

namespace ExtraaEdge.CRM.Repositoy
{
    public class SalesRepositoty : ISalesRepositoty
    {
        ExtraaEdgeCRMEntities extraaEdgeCRMEntities = null;
        public SalesRepositoty()
        {
            this.extraaEdgeCRMEntities = new ExtraaEdgeCRMEntities();
        }
        public IEnumerable<SalesDataModel> GetSalesReport(DateTime FromDate, int ReportPeriodType)
        {
            List<SalesDataModel> SalesReportRecordsList = new List<SalesDataModel>();
            if ((int)ReportPeriodTypeEnum.Monthly == ReportPeriodType)
            {
                SalesReportRecordsList= extraaEdgeCRMEntities.SALES.Where(x => x.SALES_ORDER_DATE.Value.Date >= FromDate.Date)
                 .Select(x => new SalesDataModel()
                 {
                     ID = x.ID,
                     SALES_ORDER_DATE = x.SALES_ORDER_DATE,
                     Company = x.Company,
                     AMOUNT = x.AMOUNT,
                     PLANNED = x.PLANNED,
                     COST = x.COST,
                     CREATED_BY = x.CREATED_BY,
                     CREATED_ON = x.CREATED_ON,
                     UPDATED_BY = x.UPDATED_BY,
                     UPDATED_ON = x.UPDATED_ON
                 })
                 .ToList();
            }
            else if ((int)ReportPeriodTypeEnum.Qurterly == ReportPeriodType)
            {
                SalesReportRecordsList= extraaEdgeCRMEntities.SALES.Where(x => x.SALES_ORDER_DATE.Value.Date >= FromDate.Date)
                 .Select(x => new SalesDataModel()
                 {
                     ID = x.ID,
                     SALES_ORDER_DATE = x.SALES_ORDER_DATE,
                     Company = x.Company,
                     AMOUNT = x.AMOUNT,
                     PLANNED = x.PLANNED,
                     COST = x.COST,
                     CREATED_BY = x.CREATED_BY,
                     CREATED_ON = x.CREATED_ON,
                     UPDATED_BY = x.UPDATED_BY,
                     UPDATED_ON = x.UPDATED_ON
                 })
                 .ToList();
            }
            else if ((int)ReportPeriodTypeEnum.Yearly == ReportPeriodType)
            {
                SalesReportRecordsList= extraaEdgeCRMEntities.SALES.Where(x => x.SALES_ORDER_DATE.Value.Date >= FromDate.Date)
                 .Select(x => new SalesDataModel()
                 {
                     ID = x.ID,
                     SALES_ORDER_DATE = x.SALES_ORDER_DATE,
                     Company = x.Company,
                     AMOUNT = x.AMOUNT,
                     PLANNED = x.PLANNED,
                     COST = x.COST,
                     CREATED_BY = x.CREATED_BY,
                     CREATED_ON = x.CREATED_ON,
                     UPDATED_BY = x.UPDATED_BY,
                     UPDATED_ON = x.UPDATED_ON
                 })
                 .ToList();
            }

            return SalesReportRecordsList;
        }

        public int Add(SalesDataModel salesDataModel)
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
           return this.extraaEdgeCRMEntities.SaveChanges();
        }
        public int Update(SalesDataModel salesDataModel)
        {            
            //write a common logic to assign value from one type object to other type object in Utils class lib project.            
            SALE saleObj = this.extraaEdgeCRMEntities.SALES.Where(x => x.ID == salesDataModel.ID).FirstOrDefault();
            if (saleObj != null )
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

           return this.extraaEdgeCRMEntities.SaveChanges();
        }
        public int Remove(int  SaleOrderId)
        {
            //write a common logic to assign value from one type object to other type object in Utils class lib project.            
            SALE saleObj = this.extraaEdgeCRMEntities.SALES.Where(x => x.ID == SaleOrderId).FirstOrDefault();
            if (saleObj != null)
            {
                this.extraaEdgeCRMEntities.SALES.Remove(saleObj);
            }
           return this.extraaEdgeCRMEntities.SaveChanges();
        }
             

    }
}
