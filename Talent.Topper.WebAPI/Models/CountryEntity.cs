using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Talent.Topper.WebAPI.Models
{
    public class CountryEntity
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string CountryName { get; set; }        
        public int? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}