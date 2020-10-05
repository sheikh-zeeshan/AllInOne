using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Data
{

    public interface IBookRepository
    {
        List<Book> GetAllBooks(string category);
        Book GetBookById(int id);

        bool SaveChanges();

        Task<bool> SaveChangesAsyc();

        void AddNewBook(Book mv);
    }
    public class BookRepository : IBookRepository
    {
        readonly BookContext _bkCtx;
        public BookRepository(BookContext bookContext)
        {
            _bkCtx = bookContext;
        }
        public List<Book> GetAllBooks(string category)
        {
            var result= _bkCtx.Books.ToList();

            return result;

        }

        List<Book> GetAllBooksFromSource()
        {

            return new List<Book> {

            new Book{BookPdfUrl="www.pdf.net", Category="Programming",Language="Eng", TotalPages=100,  AuthName="Peter Jackson", Id=1,LongDescp="long desc", Name="Programming in 10 days", ShortDescp="aa", ThumbnailURL="", Title="Mastering DB" },
            new Book{BookPdfUrl="www.pdf.net", Category="Programming",Language="Eng", TotalPages=100,AuthName="Andy Merphy", Id=2,LongDescp="long desc asdasd dfdsf sdfsd", Name="Angular", ShortDescp="cc", ThumbnailURL="", Title="Working in angular" },
            };


        }

        public Book GetBookById(int id)
        {
            var bkg = _bkCtx.BooksGallery.Where(x => x.BookId == id).ToList();
            var data = _bkCtx.Books.SingleOrDefault(x => x.Id == id); //GetAllBooksFromSource();

            //data.BookGalleries.AddRange(bkg);


            return data; //.SingleOrDefault(x => x.Id == id);
        }

        public void AddNewBook(Book mv)
        {
            _bkCtx.Books.Add(mv);
        }

        public bool SaveChanges()
        {
            if (_bkCtx.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> SaveChangesAsyc()
        {
            if (await _bkCtx.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
