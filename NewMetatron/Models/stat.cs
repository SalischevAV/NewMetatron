namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.stats")]
    public partial class stat
    {
        public int id { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string SIP { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Status { get; set; }

        [Required]
        [StringLength(15)]
        public string ip { get; set; }
    }
}
