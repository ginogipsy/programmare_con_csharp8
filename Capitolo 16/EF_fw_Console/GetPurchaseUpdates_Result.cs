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
    
    public partial class GetPurchaseUpdates_Result
    {
        public Nullable<System.DateTime> Date_Key { get; set; }
        public int WWI_Purchase_Order_ID { get; set; }
        public int Ordered_Outers { get; set; }
        public Nullable<int> Ordered_Quantity { get; set; }
        public int Received_Outers { get; set; }
        public string Package { get; set; }
        public bool Is_Order_Finalized { get; set; }
        public int WWI_Supplier_ID { get; set; }
        public int WWI_Stock_Item_ID { get; set; }
        public System.DateTime Last_Modified_When { get; set; }
    }
}
