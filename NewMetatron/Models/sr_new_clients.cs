namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.sr_new_clients")]
    public partial class sr_new_clients
    {
        public int id { get; set; }

        public int cdr_id { get; set; }

        public int client_num { get; set; }

        public DateTime first_call { get; set; }

        [Column(TypeName = "usmallint")]
        public int city { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime add_date { get; set; }
    }
}
