//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTrungTam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TuiTion { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<bool> IsSysTem { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string SearchText { get; set; }
    }
}
