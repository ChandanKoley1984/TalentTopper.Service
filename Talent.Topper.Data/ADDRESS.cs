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
    
    public partial class ADDRESS
    {
        public long id { get; set; }
        public string name { get; set; }
        public string addressline { get; set; }
        public string city { get; set; }
        public Nullable<int> district_id { get; set; }
        public Nullable<int> state_id { get; set; }
        public Nullable<int> country_id { get; set; }
        public string pincode { get; set; }
        public string Email { get; set; }
        public Nullable<int> Contact_id { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<long> Company_ID { get; set; }
        public Nullable<long> Branch_ID { get; set; }
        public Nullable<int> is_default { get; set; }
    }
}
