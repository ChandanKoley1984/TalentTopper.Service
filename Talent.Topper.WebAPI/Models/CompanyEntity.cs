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
        public string CEOName { get; set; }
        public string WebsiteUrl { get; set; }
        public string LogoPath { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string CompanyType { get; set; }
        public int RoleId { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string addressline { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public string City { get; set; }
        public int is_default { get; set; }
        public string ImageFile { get; set; }
    }
}