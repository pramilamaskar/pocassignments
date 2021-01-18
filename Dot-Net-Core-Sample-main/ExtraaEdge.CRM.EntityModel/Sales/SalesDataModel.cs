using System;

namespace ExtraaEdge.CRM.EntityModel
{
    public class SalesDataModel
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> SALES_ORDER_DATE { get; set; }
        public string Company { get; set; }
        public Nullable<double> AMOUNT { get; set; }
        public Nullable<double> PLANNED { get; set; }
        public Nullable<double> COST { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_ON { get; set; }
    }
}
