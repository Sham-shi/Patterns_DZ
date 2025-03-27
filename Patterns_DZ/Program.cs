using Patterns_DZ.DZ_19_03_25.ChainOfResponsobility;
using Patterns_DZ.DZ_19_03_25.ChainOfResponsobility.CreditHandlers;
using Patterns_DZ.DZ_19_03_25.Iterator;
using Patterns_DZ.DZ_19_03_25.Mediator;
using Patterns_DZ.DZ_19_03_25.Mediator.Colleagues;
using Patterns_DZ.DZ_19_03_25.State;
using Patterns_DZ.DZ_19_03_25.State.WaterStates;
using Patterns_DZ.DZ_19_03_25.TemplateMethod;

Console.WriteLine("Пример использования паттерна State\n");

var water = new Water(new LiquidWaterState());

water.Heating();
water.Cooling();
water.Cooling();
water.Cooling();
Console.WriteLine("-----------------------------------------------\n");


Console.WriteLine("Пример использования паттерна TemplateMethod\n");

var school = new School();
var university = new University();

school.Learn();
university.Learn();
Console.WriteLine("-----------------------------------------------\n");


Console.WriteLine("Пример использования паттерна Iterator\n");

var library = new Library();

library.AddBook(new Book("Война и мир"));
library.AddBook(new Book("Отцы и дети"));
library.AddBook(new Book("Маленький принц и лис"));

var libraryIterator = library.CreateNumerator();

while (libraryIterator.HasNext())
{
    var book = libraryIterator.Next();
    Console.WriteLine(book.Name);
}
Console.WriteLine("-----------------------------------------------\n");


Console.WriteLine("Пример использования паттерна ChainOfResponsobility");

var managerHadler = new ManagerHadler();
var departmentHeadHandler = new DepartmentHeadHandler();
var directorHandler = new DirectorHandler();

managerHadler
    .SetNext(departmentHeadHandler)
    .SetNext(directorHandler);

List<CreditRequest> requests = new List<CreditRequest>
{
    new CreditRequest("Иван Петров", 35_000),
    new CreditRequest("Анна Сидорова", 150_000),
    new CreditRequest("Олег Васильев", 750_000),
    new CreditRequest("Елена Ковалева", 1_000_000)
};

foreach (var request in requests)
{
    Console.WriteLine($"\nОбработка заявки: {request.ClientName} на {request.Amount}");
    managerHadler.HandlerRequest(request);
}

Console.WriteLine("-----------------------------------------------\n");


Console.WriteLine("Пример использования паттерна Mediator");

var manager = new ManagerMediator();

var customer = new CustomerCollegue(manager);
var programmer = new ProgrammerCollegue(manager);
var tester = new TesterCollegue(manager);

manager.Customer = customer;
manager.Programmer = programmer;
manager.Tester = tester;

customer.Send("Есть заказ, напиши программу");
programmer.Send("Программа написана протестируй");
tester.Send("Программа протестирована, заказ выполнен");

Console.WriteLine("-----------------------------------------------\n");