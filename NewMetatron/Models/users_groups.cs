namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.users_groups")]
    public partial class users_groups
    {
        [Column(TypeName = "umediumint")]
        public int id { get; set; }

        [Column(TypeName = "umediumint")]
        public int user_id { get; set; }

        [Column(TypeName = "umediumint")]
        public int group_id { get; set; }
    }
}
