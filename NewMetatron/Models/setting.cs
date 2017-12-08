namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.settings")]
    public partial class setting
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string section { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }
    }
}
