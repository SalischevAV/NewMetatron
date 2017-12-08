namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.groups_permissions")]
    public partial class groups_permissions
    {
        public int id { get; set; }

        public int group_id { get; set; }

        public int permission_id { get; set; }
    }
}
