﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Talent.Topper.WebAPI.Entity
{
    public class BranchEntity
    {
        [BsonId]  
        [BsonElement("_id")]      
        public ObjectId BsonId { get; set; }

        public string id { get; set; }

        [BsonElement("CompanyID")]
        public int CompanyID { get; set; }
        
        public string BranchName { get; set; }
        public string HOB { get; set; }
        public string BranchAddress { get; set; }
        public string BranchMobileNo { get; set; }
        public string BranchPhoneNo { get; set; }
        public string BranchEmailID { get; set; }
        public string City { get; set; }
        public string StateID { get; set; }
        public string CountryID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Status { get; set; }
        public string Logo { get; set; }
        public string Password { get; set; }

    }
}