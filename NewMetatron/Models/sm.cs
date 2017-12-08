namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.sms")]
    public partial class sm
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string smsc { get; set; }

        [Required]
        [StringLength(255)]
        public string sender { get; set; }

        public int ts { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string body { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string pdu { get; set; }

        public int replied { get; set; }

        [Required]
        [StringLength(255)]
        public string ip { get; set; }

        public int gsm_module { get; set; }

        public int answered { get; set; }
    }
}
