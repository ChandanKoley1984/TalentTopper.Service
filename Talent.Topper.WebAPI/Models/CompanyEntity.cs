using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent.Topper.WebAPI.Models
{
    public class CompanyEntity
    {
        public long ID { get; set; }
        public string CompanyName { get; set; }       
        public string FullAddress { get; set; }        
        public string CountryCode { get; set; }        
        public string MobileNo { get; set; }        
        public string PhoneNo { get; set; }        
        public string Email { get; set; }       
        public string WebsiteURL { get; set; }
        public string Logo { get; set; }        
        public string CEOName { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> StateID { get; set; }    
        public string City { get; set; }        
        public string ComapanyType { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}