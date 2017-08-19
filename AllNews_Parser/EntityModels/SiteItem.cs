namespace AllNews_Parser.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteItem")]
    public partial class SiteItem
    {
        public int ID { get; set; }

        public int? SiteID { get; set; }

        [StringLength(200)]
        public string SiteItemName { get; set; }

        [StringLength(200)]
        public string SiteItemURL { get; set; }

        [StringLength(1000)]
        public string SiteItemRSS { get; set; }

        [StringLength(50)]
        public string Encoding { get; set; }

        public int? Position { get; set; }

        public bool? isDefault { get; set; }

        public bool? isHide { get; set; }

        public bool? isFavorite { get; set; }

        public DateTime? loadedTime { get; set; }

        public bool? isSync { get; set; }

        [StringLength(100)]
        public string Regex { get; set; }

        [StringLength(100)]
        public string LinkRegex { get; set; }

        [StringLength(100)]
        public string TitleRegex { get; set; }

        [StringLength(100)]
        public string ImageRegex { get; set; }

        [StringLength(100)]
        public string VideoRegex { get; set; }

        [StringLength(100)]
        public string ContentRegex { get; set; }

        [StringLength(100)]
        public string PubdateRegex { get; set; }

        [StringLength(100)]
        public string MoreArticleRegex { get; set; }
    }
}
