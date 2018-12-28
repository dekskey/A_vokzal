namespace A_vokzal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Voditel")]
    public partial class Voditel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voditel()
        {
            Avtobus = new HashSet<Avtobus>();
        }

        [Required]
        [StringLength(30)]
        public string FIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime birthday_date { get; set; }

        public int pasport { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_voditel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avtobus> Avtobus { get; set; }
    }
}
