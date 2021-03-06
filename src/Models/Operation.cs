//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITech.Security.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operation
    {
        public Operation()
        {
            this.RoleOperations = new HashSet<RoleOperation>();
        }
    
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> ModelId { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<RoleOperation> RoleOperations { get; set; }
    }
}
