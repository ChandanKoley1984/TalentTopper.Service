using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Talent.Topper.WebAPI.Models
{
    public class GeneratedIDEntity
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string PrefixSeperate { get; set; }
        public string Suffix { get; set; }
        public string SuffixSeperate { get; set; }
        public string Number { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime? UpdateDate { get; set; }
        public int UpdateBy { get; set; }
    }
}