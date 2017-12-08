namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.orders")]
    public partial class order
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string phone { get; set; }

        public int? cdrid { get; set; }

        [StringLength(255)]
        public string city { get; set; }
    }
}
