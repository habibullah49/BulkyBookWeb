namespace BulkyBookWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int id { get; set; }
        [Required]

        [StringLength(50)]
        public string name { get; set; }

        public int? displayOrder { get; set; }

        public DateTime? createDateTime { get; set; }
    }
}
