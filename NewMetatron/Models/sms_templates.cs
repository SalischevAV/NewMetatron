namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.sms_templates")]
    public partial class sms_templates
    {
        public int id { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime date { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(100)]
        public string template { get; set; }
    }
}
