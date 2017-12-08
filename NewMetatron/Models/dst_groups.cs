namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.dst_groups")]
    public partial class dst_groups
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string type { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string rest_type { get; set; }

        [StringLength(255)]
        public string sms_alfa_name { get; set; }
    }
}
