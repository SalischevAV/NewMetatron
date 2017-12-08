namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.gsmgateways")]
    public partial class gsmgateway
    {
        public int id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string ip { get; set; }

        public int slots { get; set; }
    }
}
