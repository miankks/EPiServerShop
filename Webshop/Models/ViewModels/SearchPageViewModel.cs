using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Globalization;
using EPiServer.Search;
using EPiServer.Search.Queries.Lucene;
using Webshop.Models.Pages;
using EPiServer.Web.Hosting;

namespace Webshop.Models.ViewModels
{
    public class SearchPageViewModel : IPageViewModel<SearchPage>
    {
        public SearchPageViewModel(SearchPage currentPage)
        {
            CurrentPage = currentPage;
        }
        public SearchPage CurrentPage { get; set; }
        public string SearchText { get; set; }
        public List<IndexResponseItem> SearchResult { get; set; }

        public void Search(string q)
        {
            var culture = ContentLanguage.PreferredCulture.Name;
            SearchResult = new List<IndexResponseItem>();
            var fieldQuery = new FieldQuery(q);
            //var unifiedDirectoryType = typeof(EPiServer.Web.Hosting.UnifiedDirectory);

            var fieldQueryResult = SearchHandler.Instance.GetSearchResults(fieldQuery, 1, 40)
                .IndexResponseItems
                .Where(x =>
                    (x.Culture.Equals(culture) || string.IsNullOrEmpty(x.Culture)))
                .ToList();

            SearchResult.AddRange(fieldQueryResult);
        }
    }
}