namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.dst_codes")]
    public partial class dst_codes
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string type { get; set; }

        public int length { get; set; }
    }
}
