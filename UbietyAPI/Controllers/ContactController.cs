using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UbietyAPI.Models;
using UbietyAPI.Services;

namespace UbietyAPI.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        } 

        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}
