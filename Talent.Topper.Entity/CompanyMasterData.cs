using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Topper.Entity
{
    public class CompanyMaster
    {
        [BsonId]
        public ObjectId ID { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Address")]
        public string Address { get; set; }
        [BsonElement("Mobile")]
        public string Mobile { get; set; }
    }
}
