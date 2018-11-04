using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Talent.Topper.WebAPI.Models
{
    public class BranchEntity
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public int CompanyID { get; set; }
        public string BranchName { get; set; }
        public string HOB { get; set; }
        public string BranchAddress { get; set; }
        public string BranchMobileNo { get; set; }
        public string BranchPhoneNo { get; set; }
        public string BranchEmailID { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Status { get; set; }
        public string Logo { get; set; }
        public string Password { get; set; }

    }
}