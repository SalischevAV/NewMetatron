namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.c_comments")]
    public partial class c_comments
    {
        [Key]
        public int cdr_id { get; set; }

        public int? order_number { get; set; }

        [StringLength(127)]
        public string text { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime timestamp { get; set; }
    }
}
