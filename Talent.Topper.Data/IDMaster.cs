//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Talent.Topper.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class IDMaster
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string PrefixSeperate { get; set; }
        public string Suffix { get; set; }
        public string SuffixSeperate { get; set; }
        public string Number { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<long> UpdateBy { get; set; }
    }
}