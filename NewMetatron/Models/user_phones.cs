namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.user_phones")]
    public partial class user_phones
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int number { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string department { get; set; }
    }
}
