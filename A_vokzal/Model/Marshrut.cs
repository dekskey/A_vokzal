namespace A_vokzal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marshrut")]
    public partial class Marshrut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Marshrut()
        {
            Reis = new HashSet<Reis>();
        }

        [Required]
        [StringLength(50)]
        public string name_of_marshrut { get; set; }

        public int rasstoyanie { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_marshruta { get; set; }

        [StringLength(50)]
        public string Punkt_otpravleniya { get; set; }

        [StringLength(50)]
        public string Punkt_pribitiya { get; set; }

        public virtual Ostanovki Ostanovki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reis> Reis { get; set; }
    }
}
