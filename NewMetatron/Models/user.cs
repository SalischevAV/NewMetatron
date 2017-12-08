namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.users")]
    public partial class user
    {
        public int id { get; set; }

        [Column(TypeName = "varbinary")]
        [Required]
        public byte[] ip_address { get; set; }

        [Required]
        [StringLength(100)]
        public string username { get; set; }

        [Required]
        [StringLength(80)]
        public string password { get; set; }

        [StringLength(40)]
        public string salt { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [StringLength(40)]
        public string activation_code { get; set; }

        [StringLength(40)]
        public string forgotten_password_code { get; set; }

        [Column(TypeName = "uint")]
        public long? forgotten_password_time { get; set; }

        [StringLength(40)]
        public string remember_code { get; set; }

        [Column(TypeName = "uint")]
        public long created_on { get; set; }

        [Column(TypeName = "uint")]
        public long? last_login { get; set; }

        public bool? active { get; set; }

        [StringLength(50)]
        public string first_name { get; set; }

        [StringLength(50)]
        public string last_name { get; set; }

        [StringLength(100)]
        public string company { get; set; }

        [StringLength(20)]
        public string phone { get; set; }
    }
}
