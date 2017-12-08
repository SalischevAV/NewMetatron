namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.cdr")]
    public partial class cdr
    {
        public DateTime calldate { get; set; }

        [Required]
        [StringLength(80)]
        public string clid { get; set; }

        [Required]
        [StringLength(80)]
        public string src { get; set; }

        [Required]
        [StringLength(80)]
        public string dst { get; set; }

        [Required]
        [StringLength(80)]
        public string dcontext { get; set; }

        [Required]
        [StringLength(80)]
        public string channel { get; set; }

        [Required]
        [StringLength(80)]
        public string dstchannel { get; set; }

        [Required]
        [StringLength(80)]
        public string lastapp { get; set; }

        [Required]
        [StringLength(80)]
        public string lastdata { get; set; }

        public DateTime start { get; set; }

        public DateTime answer { get; set; }

        public DateTime end { get; set; }

        public int duration { get; set; }

        public int billsec { get; set; }

        [Required]
        [StringLength(45)]
        public string disposition { get; set; }

        public int amaflags { get; set; }

        [Required]
        [StringLength(20)]
        public string accountcode { get; set; }

        [Required]
        [StringLength(255)]
        public string userfield { get; set; }

        [Required]
        [StringLength(32)]
        public string uniqueid { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string ip { get; set; }
    }
}
