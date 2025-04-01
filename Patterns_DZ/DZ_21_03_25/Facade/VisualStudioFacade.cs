
namespace Patterns_DZ.DZ_21_03_25.Facade;

public class VisualStudioFacade
{
    private TextEditor _textEditor;
    private Compiler _compiler;
    private CLR _clr;

    public VisualStudioFacade(TextEditor textEditor, Compiler compiler, CLR clr)
    {
        _textEditor = textEditor;
        _compiler = compiler;
        _clr = clr;
    }

    public void Start()
    {
        _textEditor.CreateCode();
        _textEditor.SaveCode();

        _compiler.Compile();

        _clr.Execute();
    }

    public void Stop()
    {
        _clr.Finish();
    }
}
