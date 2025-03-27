
namespace Patterns_DZ.DZ_19_03_25.Iterator;

public class LibraryIterator : IBookIterator
{
    private List<Book> _books;
    private int _current = 0;

    public LibraryIterator(List<Book> books)
    {
        _books=books;
    }

    public bool HasNext()
    {
        return _current < _books.Count;
    }

    public Book Next()
    {
        if(HasNext())
        {
            return _books[_current++];
        }

        throw new Exception();
    }
}
