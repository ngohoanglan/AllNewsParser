namespace AllNews_Parser.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImagesDB")]
    public partial class ImagesDB
    {
        [Key]
        public int ImageID { get; set; }

        public int ArticleID { get; set; }

        public int? naturalHeight { get; set; }

        public int? naturalWidth { get; set; }

        public int? width { get; set; }

        public int? height { get; set; }

        [StringLength(500)]
        public string title { get; set; }

        [StringLength(500)]
        public string url { get; set; }

        public bool? primary { get; set; }
    }
}
