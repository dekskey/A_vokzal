namespace A_vokzal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tip avtobusa")]
    public partial class Tip_avtobusa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tip_avtobusa()
        {
            Avtobus = new HashSet<Avtobus>();
        }

        [Key]
        [StringLength(20)]
        public string model_avtobusa { get; set; }

        public int kol_mest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avtobus> Avtobus { get; set; }
    }
}
