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
    
    public partial class SubFacility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubFacility()
        {
            this.TransactionDetails = new HashSet<TransactionDetail>();
        }
    
        public int subfacilityid { get; set; }
        public int facilityid { get; set; }
        public string subfacilityname { get; set; }
    
        public virtual Facility Facility { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
