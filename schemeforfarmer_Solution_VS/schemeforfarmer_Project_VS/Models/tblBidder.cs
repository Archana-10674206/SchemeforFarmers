//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace schemeforfarmer_Project_VS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBidder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBidder()
        {
            this.tblBidCrops = new HashSet<tblBidCrop>();
            this.tblBids = new HashSet<tblBid>();
            this.tblUsers = new HashSet<tblUser>();
        }
    
        public int bId { get; set; }
        public string bUserName { get; set; }
        public string bContactNo { get; set; }
        public string bAddress { get; set; }
        public string bCity { get; set; }
        public string bState { get; set; }
        public string bPincode { get; set; }
        public string bAccountNo { get; set; }
        public string bIFSCcode { get; set; }
        public string bAadhar { get; set; }
        public string bPan { get; set; }
        public string bTraderLicense { get; set; }
        public string bPassword { get; set; }
        public string StatusOfBidderDocx { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string bEmailId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBidCrop> tblBidCrops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBid> tblBids { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }
    }
}
