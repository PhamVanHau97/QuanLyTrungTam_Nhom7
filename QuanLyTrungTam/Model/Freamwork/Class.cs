//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Freamwork
{
    using System;
    using System.Collections.Generic;
    
    public partial class Class
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int IDSubject { get; set; }
        public int IDTeacher { get; set; }
        public int IDRoom { get; set; }
        public int IDExam { get; set; }
        public bool Status { get; set; }
        public Nullable<int> Mon { get; set; }
        public Nullable<int> Tus { get; set; }
        public Nullable<int> Wed { get; set; }
        public Nullable<int> Thu { get; set; }
        public Nullable<int> Fri { get; set; }
        public Nullable<int> Sat { get; set; }
        public Nullable<int> Sun { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSystem { get; set; }
        public int CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string SearchText { get; set; }
    }
}