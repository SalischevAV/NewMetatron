namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.lost_clients")]
    public partial class lost_clients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cdr_id { get; set; }

        public DateTime start { get; set; }

        public int client_num { get; set; }
    }
}
