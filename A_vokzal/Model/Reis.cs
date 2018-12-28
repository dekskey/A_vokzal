namespace A_vokzal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reis()
        {
            Bilet = new HashSet<Bilet>();
        }

        public int nomer_reisa { get; set; }

        [Key]
        public TimeSpan time_ot { get; set; }

        public TimeSpan time_pr { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int nomer_avtobusa { get; set; }

        public int? nomer_marshruta { get; set; }

        public virtual Avtobus Avtobus { get; set; }

        public virtual Marshrut Marshrut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }
    }
}
