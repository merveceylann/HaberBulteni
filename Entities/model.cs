﻿using Entities;
using Newtonsoft.Json;

namespace deneme1
{
    public class model
    {
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("http://turkmedya.com.tr/anasayfa.json"))
            {
                string json = r.ReadToEnd();
                List<Itemlist> items = JsonConvert.DeserializeObject<List<Itemlist>>(json);
            }
        }

        public class Itemlist
        {
            public bool hasPhotoGallery { get; set; }
            public bool hasVideo { get; set; }
            public bool titleVisible { get; set; }
            public string fLike { get; set; }
            public string publishDate { get; set; }
            public string shortText { get; set; }
            public string fullPath { get; set; }
            public Category category { get; set; }
            public string videoUrl { get; set; }
            public string externalUrl { get; set; }
            public string columnistName { get; set; }
            public string itemId { get; set; }
            public string title { get; set; }
            public string imageUrl { get; set; }
            public string itemType { get; set; }
        }
      
    }

}
