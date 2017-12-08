namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.dst2group")]
    public partial class dst2group
    {
        public int id { get; set; }

        public int group { get; set; }

        public int dst { get; set; }
    }
}
