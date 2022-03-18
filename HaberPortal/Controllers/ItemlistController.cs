using AutoMapper;
using HaberPortal.ApiService;
using HaberPortal.Models;
using HaberPortal.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberPortal.Controllers
{
    public class ItemlistController : Controller
    {
        private readonly RootApiService _itemlistApiService;
        private readonly DetailApiService _detailApiService;

        public ItemlistController(DetailApiService detailApiService, RootApiService itemlistApiService)
        {
            _itemlistApiService = itemlistApiService;
            _detailApiService = detailApiService;
        }

        public async Task<IActionResult> Index(string searchTitle, string categoryId, int? pageNumber)
        {
            var rootObject = await _itemlistApiService.GetAllAsync();

            var allNews = rootObject.data.SelectMany(x => x.itemList).ToList();

            var newsVm = allNews.Select(x => new NewsViewModel
            {
                Id = x.itemId,
                Title = x.title,
                ImageUrl = x.imageUrl,
                CategoryId = x.category.categoryId
            }).ToList();

            var categoriesVm = allNews.Select(x => new CategoriesViewModel
            {
                Id = x.category.categoryId,
                Title = x.category.title
            }).GroupBy(x => x.Id).Select(g => g.First()).ToList();


            if (!string.IsNullOrEmpty(categoryId))
            {
                newsVm = newsVm.Where(x => x.CategoryId == categoryId).ToList();
                ViewBag.searchParam = "?categoryId=" + categoryId;
            }
            else if (!string.IsNullOrEmpty(searchTitle))
            {
                newsVm = newsVm.Where(x => x.Title.ToLower().Contains(searchTitle.ToLower())).ToList();
                ViewBag.searchParam = "?searchTitle=" + searchTitle;

            }
            var d = (decimal)newsVm.Count() / 5;
            decimal totalPageNumber = Math.Ceiling(d);

            if (pageNumber != null && (pageNumber >= 0 && pageNumber <= totalPageNumber))
            {
                newsVm = newsVm.Skip(((int)pageNumber - 1) * 5).Take(5).ToList();
                ViewBag.currentPage = pageNumber;
            }
            else
            {
                newsVm = newsVm.Take(5).ToList();
                ViewBag.currentPage = 1;

            }

            var newsPageViewModel = new NewsPageViewModel
            {
                Categories = categoriesVm,
                News = newsVm,
                TotalPageNumber = (int)totalPageNumber
            };

            return View(newsPageViewModel);
        }



        public async Task<IActionResult> NewsDetail(string newsId)
        {
            var details = await _detailApiService.GetAllAsync();
            var relatedNews = new RelatedNewsViewModel
            {
                CategoryName = details.data.relatedNews.category.title,
                ImageUrl = details.data.relatedNews.imageUrl,
                ShortContent = details.data.relatedNews.shortText,
                Title = details.data.relatedNews.title
            };


            var detailVM = new DetailViewModel
            {
                RelatedNews=relatedNews,
                CategoryName=details.data.newsDetail.category.title,
                Content=details.data.newsDetail.bodyText,
                ImageUrl= details.data.newsDetail.imageUrl,
                PublishDate=details.data.newsDetail.publishDate,
                Title=details.data.newsDetail.title
            };

            return View(detailVM);
        }
    }
}
