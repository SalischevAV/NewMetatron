namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.fo_orders")]
    public partial class fo_orders
    {
        [Key]
        [StringLength(15)]
        public string code { get; set; }

        public int statusid { get; set; }

        [Required]
        [StringLength(16)]
        public string phone { get; set; }

        public int send { get; set; }
    }
}
