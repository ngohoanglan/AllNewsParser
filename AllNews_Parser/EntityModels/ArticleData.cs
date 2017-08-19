namespace AllNews_Parser.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArticleData")]
    public partial class ArticleData
    {
        [Key]
        public int ArticleID { get; set; }

        public int FeedID { get; set; }

        [StringLength(500)]
        public string Icon { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        [Column(TypeName = "text")]
        public string Text { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Html { get; set; }

        public DateTime? PubTime { get; set; }

        [StringLength(50)]
        public string CountryCode { get; set; }

        [StringLength(1000)]
        public string Url { get; set; }

        public DateTime? DownloadTime { get; set; }
    }
}
