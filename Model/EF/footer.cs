namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("footer")]
    public partial class footer
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public bool? Status { get; set; }
    }
}
