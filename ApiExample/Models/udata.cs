namespace ApiExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("udata")]
    public partial class udata
    {
        [Key]
        public int uid { get; set; }

        [StringLength(30)]
        public string uname { get; set; }

        [StringLength(30)]
        public string ucity { get; set; }
    }
}
