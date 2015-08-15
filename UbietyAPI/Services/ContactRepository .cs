using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UbietyAPI.Models;

namespace UbietyAPI.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[] {
                
                new Contact {Name = "Vibhor Mathreja" , Id = 1},
                new Contact {Name = "Shilpa Pilaka" , Id = 2},
                new Contact {Name = "Lakshman Pilaka" , Id = 3}
            };
            
        }
    }
}