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
    
    public partial class DENETIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DENETIM()
        {
            this.DENETIMSONUC = new HashSet<DENETIMSONUC>();
            this.DENETIMSONUC1 = new HashSet<DENETIMSONUC>();
        }
    
        public int ID { get; set; }
        public int KATEGORI_TIP { get; set; }
        public int MADDE_TANIM { get; set; }
        public int TUR_TIP { get; set; }
        public int TUR_PUAN { get; set; }
        public int SONUC_TIP { get; set; }
        public string GORUS { get; set; }
        public int DENETIM_PUAN { get; set; }
    
        public virtual KATEGORI KATEGORI { get; set; }
        public virtual MADDELER MADDELER { get; set; }
        public virtual SONUC SONUC { get; set; }
        public virtual TUR TUR { get; set; }
        public virtual TUR TUR1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DENETIMSONUC> DENETIMSONUC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DENETIMSONUC> DENETIMSONUC1 { get; set; }
    }
}
