namespace AllNews_Parser.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Site")]
    public partial class Site
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string SiteName { get; set; }

        [Required]
        [StringLength(200)]
        public string SiteURL { get; set; }

        [Required]
        [StringLength(2)]
        public string CountryCode { get; set; }

        [StringLength(200)]
        public string IconPath { get; set; }

        public bool? isFavorite { get; set; }

        public int? position { get; set; }

        public int? Status { get; set; }

        public int? Version { get; set; }
    }
}
