namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.fo_orderstates")]
    public partial class fo_orderstates
    {
        public int? id { get; set; }

        [StringLength(64)]
        public string name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int active { get; set; }
    }
}
