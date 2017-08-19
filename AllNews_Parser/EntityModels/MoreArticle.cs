namespace AllNews_Parser.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MoreArticle
    {
        public int ID { get; set; }

        public int ArticleID { get; set; }

        [StringLength(500)]
        public string Link { get; set; }
    }
}
