using System.Collections.Generic;
/// <summary>
/// Detailden gelecek veriyi karşılayabilmek için farklı namespacelerde farklı objeler açıldı
/// Gelen datada içerikler ve birkaç alan değişebiliyor.
/// </summary>
namespace HaberPortal.Models.DetailDtos
{
    public class HeaderAd
    {
        public string itemType { get; set; }
        public string adUnit { get; set; }
        public int itemWidth { get; set; }
        public int itemHeight { get; set; }
    }

    public class NewsDetail
    {
        public string resource { get; set; }
        public string bodyText { get; set; }
        public bool hasPhotoGallery { get; set; }
        public bool hasVideo { get; set; }
        public string publishDate { get; set; }
        public string fullPath { get; set; }
        public string shortText { get; set; }
        public Category category { get; set; }
        public string itemId { get; set; }
        public string title { get; set; }
        public string video { get; set; }
        public string imageUrl { get; set; }
        public string itemType { get; set; }
    }

    public class FooterAd
    {
        public string itemType { get; set; }
        public string adUnit { get; set; }
        public int itemWidth { get; set; }
        public int itemHeight { get; set; }
    }

    public class Multimedia
    {
        public string sectionType { get; set; }
        public string repeatType { get; set; }
        public int itemCountInRow { get; set; }
        public bool lazyLoadingEnabled { get; set; }
        public bool titleVisible { get; set; }
        public object title { get; set; }
        public object titleColor { get; set; }
        public object titleBgColor { get; set; }
        public object sectionBgColor { get; set; }
    }

    public class ItemList
    {
        public object itemList { get; set; }
        public string itemId { get; set; }
        public string title { get; set; }
        public string imageUrl { get; set; }
        public string itemType { get; set; }
        public bool titleVisible { get; set; }
        public string shortText { get; set; }
        public string bodyText { get; set; }
        public string videoUrl { get; set; }
    }

    public class RelatedNews
    {
        public bool hasPhotoGallery { get; set; }
        public bool hasVideo { get; set; }
        public string publishDate { get; set; }
        public string shortText { get; set; }
        public Category category { get; set; }
        public string itemId { get; set; }
        public string title { get; set; }
        public string imageUrl { get; set; }
        public string itemType { get; set; }
        public bool titleVisible { get; set; }
    }

    public class Video
    {
        public string shortText { get; set; }
        public string bodyText { get; set; }
        public string videoUrl { get; set; }
        public string itemId { get; set; }
        public string title { get; set; }
        public string imageUrl { get; set; }
        public string itemType { get; set; }
        public bool titleVisible { get; set; }
    }

    public class PhotoGallery
    {
        public object itemList { get; set; }
        public string itemId { get; set; }
        public string title { get; set; }
        public string imageUrl { get; set; }
        public string itemType { get; set; }
        public bool titleVisible { get; set; }
    }

    public class Data
    {
        public HeaderAd headerAd { get; set; }
        public NewsDetail newsDetail { get; set; }
        public FooterAd footerAd { get; set; }
        public Multimedia multimedia { get; set; }
        public List<ItemList> itemList { get; set; }
        public RelatedNews relatedNews { get; set; }
        public Video video { get; set; }
        public PhotoGallery photoGallery { get; set; }
    }

    public class Root
    {
        public int errorCode { get; set; }
        public string errorMessage { get; set; }
        public Data data { get; set; }
    }
   

    public class Category
    {
        public string categoryId { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
        public string color { get; set; }
    }



}
