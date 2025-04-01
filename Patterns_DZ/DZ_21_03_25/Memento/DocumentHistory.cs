
namespace Patterns_DZ.DZ_21_03_25.Memento;

public class DocumentHistory
{
    Stack<DocumentMemento> history;

    public DocumentHistory()
    {
        history = new Stack<DocumentMemento>();
    }

    public void Save(DocumentMemento memento)
    {
        history.Push(memento);
    }

    public DocumentMemento Load()
    {
        var memento = history.Pop();
        return memento;
    }
}
