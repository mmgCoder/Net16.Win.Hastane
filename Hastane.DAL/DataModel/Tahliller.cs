//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hastane.DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tahliller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tahliller()
        {
            this.HastaHizmetHareketler = new HashSet<HastaHizmetHareketler>();
        }
    
        public int TahlilID { get; set; }
        public System.DateTime Tarih { get; set; }
        public int KabulID { get; set; }
        public string Aciklama { get; set; }
        public bool Silindi { get; set; }
        public string Sonuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaHizmetHareketler> HastaHizmetHareketler { get; set; }
        public virtual HastaKabul HastaKabul { get; set; }
    }
}