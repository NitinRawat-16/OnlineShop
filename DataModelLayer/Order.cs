//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public int OrderDetailsId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
