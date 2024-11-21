
using PracticalWork2;
using static PracticalWork2.Order;

Employee waiter = new Employee(1, "Alice", Positions.Waiter, "9:00-18:00");
Employee cook = new Employee(2, "Bob", Positions.Cook, "10:00-19:00");


MenuItem pizza = new MenuItem(1, "Pizza", "Delicious Italian pizza", 10.99m, true);
MenuItem salad = new MenuItem(2, "Salad", "Fresh vegetable salad", 5.49m, true);

Menu restaurantMenu = new Menu("Restaurant Menu");
restaurantMenu.AddMenuItem(pizza);
restaurantMenu.AddMenuItem(salad);


Order order1 = new Order(101, DateTime.Now, OrderStatuses.New, Order.OrderTypes.DineIn, 0m, PaymentMethods.card);
order1.Items.Add(pizza);
order1.Items.Add(salad);
order1.CalculateTotalPrice();


waiter.AssignOrder(order1);


Client client = new Client(1, "John Doe", "123-456-7890", "john.doe@example.com");


Table table1 = new Table(1, 4, TableStatuses.available);
Table table2 = new Table(2, 2, TableStatuses.occupied);
Table table3 = new Table(3, 6, TableStatuses.reserved);


TableManager tableManager = new TableManager();
tableManager.AddTable(table1.TableId, table1.Capacity, table1.Status);
tableManager.AddTable(table2.TableId, table2.Capacity, table2.Status);
tableManager.AddTable(table3.TableId, table3.Capacity, table3.Status);


tableManager.DisplayTables();


tableManager.ReserveTable(1);


tableManager.UpdateTableStatus(2, TableStatuses.available);


Console.WriteLine($"{waiter.Name} has handled {waiter.GetOrderCount()} orders.");
Console.WriteLine($"Average service time: {waiter.CalculateAverageServiceTime()}");


order1.ViewTotalPrice();


Report report = new Report(DateTime.Now);
report.AddItemToReport("Pizza", 1);
report.AddItemToReport("Salad", 1);


Console.WriteLine("Sales Report:");
Console.WriteLine($"Date: {report.ReportDate}");
foreach (var item in report.Items)
{
    Console.WriteLine($"{item.Key}: {item.Value} sold");
}
Console.WriteLine($"Total Sales: {report.TotalSales}");