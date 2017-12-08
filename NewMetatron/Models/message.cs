namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.messages")]
    public partial class message
    {
        public int id { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime stime { get; set; }

        [Column("message", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string message1 { get; set; }
    }
}
