namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.last_calls")]
    public partial class last_calls
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int client_num { get; set; }

        public DateTime last_call { get; set; }
    }
}
