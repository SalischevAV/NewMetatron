namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.queue_log")]
    public partial class queue_log
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(32)]
        public string time { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string callid { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string queuename { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string agent { get; set; }

        [Column("event", TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string _event { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string data1 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string data2 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string data3 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string data4 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string data5 { get; set; }

        [Required]
        [StringLength(15)]
        public string ip { get; set; }
    }
}
