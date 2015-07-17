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
    
    public partial class Address
    {
        public Address()
        {
            this.EntityAddresses = new HashSet<EntityAddress>();
        }
    
        public int AddressId { get; set; }
        public int AddressTypId { get; set; }
        public string AddressName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public Nullable<int> CoordinateId { get; set; }
    
        public virtual AddressType AddressType { get; set; }
        public virtual ICollection<EntityAddress> EntityAddresses { get; set; }
    }
}
