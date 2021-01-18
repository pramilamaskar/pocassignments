using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtraaEdge.CRM.BusinessLayer;
using ExtraaEdge.CRM.BusinessLayerr;
using ExtraaEdge.CRM.EntityModel;
using Microsoft.AspNetCore.Mvc;

namespace ExtraaEdge.CRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        ISalesBusinessLayer ISalesBusinessLayer;

        public SalesController()
        {          
            ISalesBusinessLayer = new SalesBusinessLayer(); ;
        }


        [HttpGet]
        public IEnumerable<Object> GetSalesReport(DateTime FromDate, int ReportPeriodType)
        {
            return ISalesBusinessLayer.GetSalesReport(FromDate, ReportPeriodType);
        }

        [HttpDelete]
        public int RemoveSale(int SaleOrderId)
        {
            return ISalesBusinessLayer.Remove(SaleOrderId);
        }


        [HttpPut]
        public int UpdateSale(DateTime SALES_ORDER_DATE, string Company,double AMOUNT ,double PLANNED ,string UPDATED_BY)
        {
            return ISalesBusinessLayer.Update( SALES_ORDER_DATE,  Company,  AMOUNT,  PLANNED,  UPDATED_BY);
        }


        [HttpPost]
        public int  AddSale(DateTime SALES_ORDER_DATE, string Company, double AMOUNT, double PLANNED, string CREATED_BY)
        {
            return ISalesBusinessLayer.Add( SALES_ORDER_DATE,  Company,  AMOUNT,  PLANNED,  CREATED_BY);
        }

    }
}