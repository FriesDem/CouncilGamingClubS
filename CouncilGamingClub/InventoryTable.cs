//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CouncilGamingClub
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryTable
    {
        public int ID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Type_Of_Item { get; set; }
        public Nullable<int> Amount { get; set; }
        public string SupplierID { get; set; }
    
        public virtual SupplierTable SupplierTable { get; set; }
    }
}