namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.settings_sms_order")]
    public partial class settings_sms_order
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string prefix { get; set; }

        [Required]
        [StringLength(20)]
        public string smsc { get; set; }

        [Required]
        [StringLength(20)]
        public string cell { get; set; }
    }
}
