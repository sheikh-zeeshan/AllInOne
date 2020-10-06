using BlogSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Components
{
    public class TopBooksViewComponent : ViewComponent
    {
        IBookRepository _bookrepo;
        public TopBooksViewComponent(IBookRepository book)
        {
            _bookrepo = book;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var books = await _bookrepo.GetTopBooksAsync();

            return await Task.FromResult((IViewComponentResult)View(books));
        }
    }
}
