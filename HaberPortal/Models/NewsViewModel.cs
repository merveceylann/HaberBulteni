using System.Collections.Generic;

namespace HaberPortal.Models
{
    public class NewsPageViewModel
    {
        public List<NewsViewModel> News { get; set; }
        public List<CategoriesViewModel> Categories { get; set; }
        public int TotalPageNumber { get; set; }
    }

    public class NewsViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryId { get; set; }
    }

    public class CategoriesViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }
}
