using System.Collections.Generic;

namespace HaberPortal.Models
{
    public class DetailViewModel
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public RelatedNewsViewModel RelatedNews { get; set; }
    }

    public class RelatedNewsViewModel
    {
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
