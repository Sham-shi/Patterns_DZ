using Patterns_DZ.DZ_21_03_25.Adapter;
using Patterns_DZ.DZ_21_03_25.Composite;
using Patterns_DZ.DZ_21_03_25.Decorator.Decorators;
using Patterns_DZ.DZ_21_03_25.Decorator.Pizzas;
using Patterns_DZ.DZ_21_03_25.Facade;
using Patterns_DZ.DZ_21_03_25.Memento;
using Patterns_DZ.DZ_21_03_25.Proxy;
using Patterns_DZ.DZ_21_03_25.Visitor.Employees;
using Patterns_DZ.DZ_21_03_25.Visitor.Visitors;
using Directory = Patterns_DZ.DZ_21_03_25.Composite.Directory;
using File = Patterns_DZ.DZ_21_03_25.Composite.File;

var document = new Document("text", "Arial", 14);
var documentHistory = new DocumentHistory();

document.PrintCurrentMemento();
var memento = document.SaveMemento();

documentHistory.Save(memento);

document.EditText("new text");
document.ChangeFont("Calibri");
document.ChangeFontSize(12);
document.PrintCurrentMemento();

documentHistory.Save(document.SaveMemento());

document.EditText("new new text");
document.PrintCurrentMemento();

memento = documentHistory.Load();
document.RestoreMemento(memento);
document.PrintCurrentMemento();

memento = documentHistory.Load();
document.RestoreMemento(memento);
document.PrintCurrentMemento();



var employees = new List<IVisitable>
{
    new OfficeEmployee("Petr", 80_000, 10_000),
    new SalesEmployee("Anna", 120_000, 10_000),
    new OfficeEmployee("Sveta", 90_000, 20_000),
    new SalesEmployee("Anvar", 70_000, 40_000)
};

var compensationVisitor = new CompensationVisitor();
foreach (var employee in employees)
{
    employee.Accept(compensationVisitor);
    Console.WriteLine(compensationVisitor.TotalCompensation);
}

var stockOptionVisitor =  new StockOptionVisitor();
foreach (var employee in employees)
{
    employee.Accept(stockOptionVisitor);
    Console.WriteLine(stockOptionVisitor.TotalUnit);
}



Pizza pizza1 = new ItalianPizza();
pizza1 = new TomatoPizza(pizza1);
Console.WriteLine("Название: " + pizza1.Name);
Console.WriteLine("Цена: " + pizza1.GetCost());

Pizza pizza2 = new BulgerianPizza();
pizza2 = new TomatoPizza(pizza2);
pizza2 = new CheesePizza(pizza2);
Console.WriteLine("Название: " + pizza2.Name);
Console.WriteLine("Цена: " + pizza2.GetCost());



Driver driver = new Driver();
Auto auto = new Auto();
driver.Travel(auto);

Camel camel = new Camel();
ITransport camelTransport = new CamelToTransportAdapter(camel);

driver.Travel(camelTransport);



var textEditor = new TextEditor();
var copiler = new Compiler();
var clr = new CLR();

var visualStudioFacade = new VisualStudioFacade(textEditor, copiler, clr);

visualStudioFacade.Start();
visualStudioFacade.Stop();



Component fileSystem = new Directory("Файловая система");
Component diskC = new Directory("Диск С");

Component pngFile = new File("Png.png");
Component docxFile = new File("Document.docx");

diskC.Add(pngFile);
diskC.Add(docxFile);

fileSystem.Add(diskC);

fileSystem.Print();

diskC.Remove(pngFile);

fileSystem.Print();



IImage image = new ProxyImage("12.jpeg");

image.Display();