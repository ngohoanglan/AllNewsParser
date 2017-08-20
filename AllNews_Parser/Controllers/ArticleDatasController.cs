using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AllNews_Parser.EntityModels;
using AllNews_Parser.Models;

namespace AllNews_Parser.Controllers
{
    [RoutePrefix("api/ArticleData")]
    public class ArticleDatasController : ApiController
    {
        private AllNewsContext db = new AllNewsContext();

       
        [Route("{urlEncrypted}/{siteItemUrlEncrypted}")]
        // GET: api/ArticleDatas/5
        [ResponseType(typeof(ArticleData))]
        public IHttpActionResult GetArticleData(string urlEncrypted,string siteItemUrlEncrypted)
        {
            Utils util = new Utils();
            ArticleData articleData = util.getArticleDataFromURL(urlEncrypted, siteItemUrlEncrypted);
            if (articleData == null)
            {
                return NotFound();
            }

            return Ok(articleData);
        }
        
    }
}