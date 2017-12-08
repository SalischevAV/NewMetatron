namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.offline_droped")]
    public partial class offline_droped
    {
        public int id { get; set; }

        [Required]
        [StringLength(13)]
        public string dst { get; set; }

        [Required]
        [StringLength(32)]
        public string unique_id { get; set; }
    }
}
