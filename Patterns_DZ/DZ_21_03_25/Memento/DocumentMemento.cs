
namespace Patterns_DZ.DZ_21_03_25.Memento;

public class DocumentMemento
{
    public string Text { get; private set; }
    public string Font { get; private set; }
    public int FontSize { get; private set; }

    public DocumentMemento(string text, string font, int fontSize)
    {
        Text = text;
        Font = font;
        FontSize = fontSize;
    }
}
