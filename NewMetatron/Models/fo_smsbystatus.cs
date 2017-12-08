namespace NewMetatron.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asterisk.fo_smsbystatus")]
    public partial class fo_smsbystatus
    {
        public int id { get; set; }

        public int statusid { get; set; }

        [Required]
        [StringLength(256)]
        public string smstext { get; set; }

        public int active { get; set; }

        public int createuserid { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime createdate { get; set; }

        public int? modifyuserid { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? modfydate { get; set; }

        [Required]
        [StringLength(1024)]
        public string xmltemplate { get; set; }
    }
}
