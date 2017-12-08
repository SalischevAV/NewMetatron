namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.balances_settings")]
    public partial class balances_settings
    {
        public int id { get; set; }

        public int gsmid { get; set; }

        public int module { get; set; }

        [Column(TypeName = "uint")]
        public long iddep { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string cell { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string test { get; set; }

        [Required]
        [StringLength(8)]
        public string sms_key { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string desc { get; set; }
    }
}
