using BookStore.API.Models;

namespace BookStore.API.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        void AddBook(Book book);
        Book DeleteBook(int id);
        void UpdateBook(Book book);
    }
}
