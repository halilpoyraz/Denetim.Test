//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DENETİM
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOLUM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOLUM()
        {
            this.MADDELER = new HashSet<MADDELER>();
            this.MADDELER1 = new HashSet<MADDELER>();
        }
    
        public int ID { get; set; }
        public int BOLUM_NO { get; set; }
        public string BOLUM_AD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MADDELER> MADDELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MADDELER> MADDELER1 { get; set; }
    }
}
