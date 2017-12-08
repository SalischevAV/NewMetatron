namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.offline_queue")]
    public partial class offline_queue
    {
        public int id { get; set; }

        [Required]
        [StringLength(31)]
        public string cdr_id { get; set; }

        public int priority { get; set; }

        [Required]
        [StringLength(31)]
        public string status { get; set; }

        public short cityID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? add_time { get; set; }
    }
}
