//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UbietyAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceFlag
    {
        public AttendanceFlag()
        {
            this.Attendances = new HashSet<Attendance>();
        }
    
        public int AttendanceFlagId { get; set; }
        public string FlagName { get; set; }
    
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
