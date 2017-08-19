namespace AllNews_Parser.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VideosDB")]
    public partial class VideosDB
    {
        [Key]
        public int VideoID { get; set; }

        public int ArticleID { get; set; }

        [StringLength(500)]
        public string url { get; set; }

        public bool? primary { get; set; }
    }
}
