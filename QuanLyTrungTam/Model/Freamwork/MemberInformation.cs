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
    
    public partial class MemberInformation
    {
        public int ID { get; set; }
        public int IDRole { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string NumberPhone { get; set; }
        public string Mail { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSystem { get; set; }
        public int CreateBy { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string SearchText { get; set; }
    }
}
