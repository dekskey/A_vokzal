namespace A_vokzal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bilet")]
    public partial class Bilet
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mesto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int platforma { get; set; }

        [Key]
        [Column(Order = 2)]
        public TimeSpan time_ot { get; set; }

        [Key]
        [Column(Order = 3)]
        public TimeSpan time_pr { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stoimost { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string FIO { get; set; }

        public virtual Passazhir Passazhir { get; set; }

        public virtual Reis Reis { get; set; }
    }
}
