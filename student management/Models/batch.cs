//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace student_management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class batch
    {
        public batch()
        {
            this.registations = new HashSet<registation>();
        }
    
        public int id { get; set; }
        public string batch1 { get; set; }
        public string year { get; set; }
    
        public virtual ICollection<registation> registations { get; set; }
    }
}
