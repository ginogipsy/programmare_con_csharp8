//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_fw_Console
{
    using System;
    
    public partial class GetSaleUpdates_Result
    {
        public Nullable<System.DateTime> Invoice_Date_Key { get; set; }
        public Nullable<System.DateTime> Delivery_Date_Key { get; set; }
        public int WWI_Invoice_ID { get; set; }
        public string Description { get; set; }
        public string Package { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> Unit_Price { get; set; }
        public decimal Tax_Rate { get; set; }
        public Nullable<decimal> Total_Excluding_Tax { get; set; }
        public decimal Tax_Amount { get; set; }
        public decimal Profit { get; set; }
        public decimal Total_Including_Tax { get; set; }
        public int Total_Dry_Items { get; set; }
        public int Total_Chiller_Items { get; set; }
        public int WWI_City_ID { get; set; }
        public int WWI_Customer_ID { get; set; }
        public int WWI_Bill_To_Customer_ID { get; set; }
        public int WWI_Stock_Item_ID { get; set; }
        public int WWI_Saleperson_ID { get; set; }
        public System.DateTime Last_Modified_When { get; set; }
    }
}
