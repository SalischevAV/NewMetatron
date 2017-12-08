namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.restaurants")]
    public partial class restaurant
    {
        public int id { get; set; }

        public int city_id { get; set; }

        public int brand_id { get; set; }

        [Required]
        [StringLength(31)]
        public string name { get; set; }
    }
}
