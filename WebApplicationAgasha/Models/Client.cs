//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationAgasha.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public Nullable<int> city { get; set; }
        public Nullable<int> AmountOfMoney { get; set; }
    
        public virtual City City1 { get; set; }
    }
}