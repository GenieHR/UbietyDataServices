//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UbietyDataServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class attendancereport
    {
        public int empid { get; set; }
        public Nullable<double> inlatitude { get; set; }
        public Nullable<double> outlatitude { get; set; }
        public Nullable<double> inlongitude { get; set; }
        public Nullable<double> outlongitude { get; set; }
        public Nullable<System.DateTime> inmarktime { get; set; }
        public Nullable<System.DateTime> outmarktime { get; set; }
    }
}