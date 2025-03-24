using System.Xml.Linq;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.Documents
{
    public abstract class Document
    {
        //формируем документ
        public abstract void Formation();

        //сохраняем документ по пути path
        public abstract void Save(string path);

        //загружаем документ
        public abstract void Load(string path);

        //редактируем документ
        public abstract void Edit();
    }
}
