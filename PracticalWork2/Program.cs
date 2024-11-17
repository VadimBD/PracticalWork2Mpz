
using PracticalWork2;

var client1 = new Client(1, "Иван Иванов", "+380123456789", "ivan@email.com");
var client2 = new Client(2, "Мария Петрова", "+380987654321", "maria@email.com");


var employee1 = new Employee(1, "Алексей Смирнов", Positions.Waiter, "9:00-18:00");
var employee2 = new Employee(2, "Ольга Кузнецова", Positions.Cook, "10:00-19:00");
var employee3 = new Employee(3, "Сергей Иванов", Positions.Courier, "12:00-21:00");


var menuItem1 = new MenuItem(1, "Паста", "Итальянская паста с соусом", 150.00m, true);
var menuItem2 = new MenuItem(2, "Салат Цезарь", "Салат с курицей и соусом Цезарь", 120.00m, true);
var menu = new Menu("Основное меню", new List<MenuItem> { menuItem1, menuItem2 });


var table1 = new Table(1, 4, TableStatuses.available);
var table2 = new Table(2, 2, TableStatuses.occupied);


var order1 = new Order(1, DateTime.Now, OrderStatuses.New, OrderTypes.DineIn, 270.00m, PaymentMethods.card);
order1.Items.Add(menuItem1);
order1.Items.Add(menuItem2);

var order2 = new Order(2, DateTime.Now, OrderStatuses.New, OrderTypes.Takeout, 150.00m, PaymentMethods.online);
order2.Items.Add(menuItem1);

client1.Orders.Add(order1);
client2.Orders.Add(order2);


employee1.AssignedOrders.Add(order1); 
employee2.AssignedOrders.Add(order1);  
employee3.AssignedOrders.Add(order2);  


var payment1 = new Payment(1, order1.TotalAmount, PaymentMethods.card, "successful");
var payment2 = new Payment(2, order2.TotalAmount, PaymentMethods.online, "successful");


var report = new Report(DateTime.Now);
report.AddItemToReport(menuItem1.Name, 2);
report.AddItemToReport(menuItem2.Name, 1); 


Console.WriteLine("Отчет по продажам:");
Console.WriteLine($"Дата отчета: {report.ReportDate}");
Console.WriteLine($"Общий доход: {report.TotalSales}");
Console.WriteLine("Популярные блюда:");
foreach (var item in report.Items)
{
    Console.WriteLine($"- {item.Key}: {item.Value} продаж");
}

Console.WriteLine("\nИнформация о заказах:");
Console.WriteLine($"Заказ клиента {client1.Name}:");
Console.WriteLine($"  Статус: {order1.Status}, Сумма: {order1.TotalAmount} грн");
Console.WriteLine($"  Способ оплаты: {order1.PaymentMethod}, Столик: {table1.TableId}");

Console.WriteLine($"\nЗаказ клиента {client2.Name}:");
Console.WriteLine($"  Статус: {order2.Status}, Сумма: {order2.TotalAmount} грн");
Console.WriteLine($"  Способ оплаты: {order2.PaymentMethod}, Столик: {table2.TableId}");
    
