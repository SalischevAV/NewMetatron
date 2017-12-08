namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.cdr_offline")]
    public partial class cdr_offline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public DateTime start { get; set; }

        [Required]
        [StringLength(7)]
        public string rest { get; set; }

        [Required]
        [StringLength(10)]
        public string src { get; set; }

        [Required]
        [StringLength(10)]
        public string dst { get; set; }

        [Required]
        [StringLength(31)]
        public string dst_name { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(5)]
        public string _operator { get; set; }

        [Required]
        [StringLength(10)]
        public string client_num { get; set; }

        public int wait_time { get; set; }

        public int speak_time { get; set; }

        [Required]
        [StringLength(31)]
        public string status { get; set; }

        [Column(TypeName = "set")]
        [Required]
        [StringLength(65531)]
        public string type { get; set; }

        [StringLength(32)]
        public string uniqueid { get; set; }

        public int call_id { get; set; }

        public short cityID { get; set; }
    }
}
