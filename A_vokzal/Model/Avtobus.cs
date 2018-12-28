namespace A_vokzal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Avtobus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Avtobus()
        {
            Reis = new HashSet<Reis>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nomer { get; set; }

        [Required]
        [StringLength(10)]
        public string nomernoy_znak { get; set; }

        public int id_voditel { get; set; }

        [Required]
        [StringLength(20)]
        public string model { get; set; }

        public virtual Tip_avtobusa Tip_avtobusa { get; set; }

        public virtual Voditel Voditel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reis> Reis { get; set; }
    }
}
