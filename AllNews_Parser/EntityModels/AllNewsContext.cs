namespace AllNews_Parser.EntityModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AllNewsContext : DbContext
    {
        public AllNewsContext()
            : base("name=AllNewsModel")
        {
        }

        public virtual DbSet<ArticleData> ArticleDatas { get; set; }
        public virtual DbSet<ImagesDB> ImagesDBs { get; set; }
        public virtual DbSet<MoreArticle> MoreArticles { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SiteItem> SiteItems { get; set; }
        public virtual DbSet<VideosDB> VideosDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleData>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleData>()
                .Property(e => e.Html)
                .IsUnicode(false);
        }
    }
}
