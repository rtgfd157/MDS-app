//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDSapp3
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersItem
    {
        public int ID { get; set; }
    
        public virtual t_Items t_Items { get; set; }
        public virtual t_Orders t_Orders { get; set; }
    }
}
