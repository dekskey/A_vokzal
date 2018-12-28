namespace A_vokzal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ostanovki")]
    public partial class Ostanovki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ostanovki()
        {
            Marshrut = new HashSet<Marshrut>();
        }

        [Required]
        [StringLength(20)]
        public string name_ost { get; set; }

        [Required]
        [StringLength(20)]
        public string punkt_ot { get; set; }

        [Required]
        [StringLength(20)]
        public string punkt_naz { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rasst_do_ost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marshrut> Marshrut { get; set; }
    }
}
