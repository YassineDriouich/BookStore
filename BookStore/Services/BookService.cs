using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Services
{
    public class BookService : IBookService
    {
        private readonly DBContextBookStore _dBContextBookStore;

        public BookService(DBContextBookStore dBContextBookStore)
        {
            _dBContextBookStore = dBContextBookStore;
        }

        public void AddBook(Book book)
        {
            _dBContextBookStore.books.Add(book);
            _dBContextBookStore.SaveChanges();
        }

        public Book DeleteBook(int id)
        {
            Book book=GetBook(id);
            _dBContextBookStore.books.Remove(book);
            _dBContextBookStore.SaveChanges();
            return book;
        }

        public Book GetBook(int id)
        {
            return _dBContextBookStore.books.Find(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dBContextBookStore.books.ToList();
        }

        public void UpdateBook(Book book)
        {
            _dBContextBookStore.Entry(book).State= EntityState.Modified;
            _dBContextBookStore.SaveChanges();
        }
    }
}
