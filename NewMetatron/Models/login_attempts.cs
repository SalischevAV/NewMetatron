namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.login_attempts")]
    public partial class login_attempts
    {
        [Column(TypeName = "umediumint")]
        public int id { get; set; }

        [Column(TypeName = "varbinary")]
        [Required]
        public byte[] ip_address { get; set; }

        [Required]
        [StringLength(100)]
        public string login { get; set; }

        [Column(TypeName = "uint")]
        public long? time { get; set; }
    }
}
