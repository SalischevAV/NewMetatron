namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.balances")]
    public partial class balance
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string ip { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gsm { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string num { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ts { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "text")]
        [StringLength(65535)]
        public string text { get; set; }
    }
}
