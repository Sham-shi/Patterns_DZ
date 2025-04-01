
namespace Patterns_DZ.DZ_21_03_25.Proxy;

public class RealImage : IImage
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Load()
    {
        Console.WriteLine("Загрузка изображения: " + _fileName);
    }

    public void Display()
    {
        Console.WriteLine(_fileName);
    }
}
