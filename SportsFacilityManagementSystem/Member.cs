//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportsFacilityManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int memberid { get; set; }
        public string name { get; set; }
        public string icno { get; set; }
        public string address { get; set; }
        public Nullable<int> mobileno { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> dateofbirth { get; set; }
        public Nullable<System.DateTime> joindate { get; set; }
        public Nullable<System.DateTime> expirydate { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
