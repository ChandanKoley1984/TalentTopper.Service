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
    
    public partial class MENU_MASTER
    {
        public long ID { get; set; }
        public string MenuName { get; set; }
        public Nullable<long> ParentID { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> SL_NO { get; set; }
    }
}
