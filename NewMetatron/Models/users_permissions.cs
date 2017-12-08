namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.users_permissions")]
    public partial class users_permissions
    {
        [Column(TypeName = "umediumint")]
        public int id { get; set; }

        [Column(TypeName = "umediumint")]
        public int user_id { get; set; }

        [Column(TypeName = "umediumint")]
        public int permission_id { get; set; }
    }
}
