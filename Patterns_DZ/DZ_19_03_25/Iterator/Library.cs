
namespace Patterns_DZ.DZ_19_03_25.Iterator;

public class Library : IBookNumerable
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public IBookIterator CreateNumerator()
    {
        return new LibraryIterator(books);
    }
}
