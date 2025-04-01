
using static System.Net.Mime.MediaTypeNames;

namespace Patterns_DZ.DZ_21_03_25.Memento;

public class Document
{
    private string _text;
    private string _font;
    private int _fontSize;

    public Document(string text, string font, int fontSize)
    {
        _text = text;
        _font = font;
        _fontSize = fontSize;
    }

    public DocumentMemento SaveMemento()
    {
        return new DocumentMemento(_text, _font, _fontSize);
    }

    public void RestoreMemento(DocumentMemento memento)
    {
        _text = memento.Text;
        _font = memento.Font;
        _fontSize = memento.FontSize;
    }

    public void EditText(string text)
    {
        _text = text;
    }

    public void ChangeFont(string font)
    {
        _font = font;
    }

    public void ChangeFontSize(int fontSize)
    {
        _fontSize = fontSize;
    }

    public void PrintCurrentMemento()
    {
        Console.WriteLine(_text + " " + _font + " " + _fontSize);
    }
}
