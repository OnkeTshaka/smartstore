using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartStore.Models.Blogs
{
    public class BlogPost
    {

        [Key, ScaffoldColumn(false), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string body { get; set; }

        //public IList<Tag> Tags { get; set; }

        public DateTime createdOn { get; set; } = DateTime.Now;

        public string image { get; set; }

        public bool AllowComments { get; set; }
    }
}