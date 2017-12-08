namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.fo_smsbuffer")]
    public partial class fo_smsbuffer
    {
        [Key]
        public long bufferid { get; set; }

        [Required]
        [StringLength(15)]
        public string code { get; set; }

        public long autono { get; set; }

        [Required]
        [StringLength(16)]
        public string phonenumber { get; set; }

        [Required]
        [StringLength(163)]
        public string smstext { get; set; }

        [Required]
        [StringLength(1024)]
        public string xmltext { get; set; }

        [Required]
        [StringLength(6)]
        public string statecode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime statedate { get; set; }

        [Required]
        [StringLength(16)]
        public string reference { get; set; }

        [Required]
        [StringLength(1024)]
        public string xmlanswer { get; set; }

        public int force { get; set; }
    }
}
