using System.Collections.Generic;

namespace BookReading.Models
{
    public interface IBookContext
    {
        void AddBook(Book newBook);
        void AddReview(Review newReview);
        List<Book> GetAll();
        List<Book> GetTop20Books();
        int Count();
        List<Book> GetRange(int from, int to);
        Book GetBook(int bookId);
        Book Update(Book newBookData);
        void AddMark(int bookId, int newValue);
    }
}