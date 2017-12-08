namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.brand")]
    public partial class brand
    {
        public int id { get; set; }

        [Required]
        [StringLength(31)]
        public string name { get; set; }
    }
}
