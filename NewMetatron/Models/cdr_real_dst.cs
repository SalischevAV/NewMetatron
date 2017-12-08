namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.cdr_real_dst")]
    public partial class cdr_real_dst
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string src { get; set; }

        [Required]
        [StringLength(15)]
        public string dst { get; set; }

        public int? src_id { get; set; }

        public int? dst_id { get; set; }

        public int extra_destination { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string type { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string status { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string rest_type { get; set; }
    }
}
