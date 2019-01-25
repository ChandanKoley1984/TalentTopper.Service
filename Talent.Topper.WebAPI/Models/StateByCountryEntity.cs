using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Talent.Topper.WebAPI.Models
{
    public class StateByCountryEntity
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string CountryId { get; set; }
        public string StateName { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}