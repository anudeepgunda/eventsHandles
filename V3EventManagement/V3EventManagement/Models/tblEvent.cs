//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace V3EventManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEvent()
        {
            this.tblRegistrations = new HashSet<tblRegistration>();
        }
    
        public int EventID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CatagoryID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public int LocationID { get; set; }
        public bool AllowRegistration { get; set; }
        public byte[] EventLogo { get; set; }
        public byte[] EventImage { get; set; }
        public decimal AdultPrice { get; set; }
        public decimal ChildPrice { get; set; }
    
        public virtual tblCatagory tblCatagory { get; set; }
        public virtual tblLocation tblLocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistration> tblRegistrations { get; set; }
    }
}
