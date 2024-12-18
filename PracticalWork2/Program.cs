
using PracticalWork2;
using static PracticalWork2.Order;

 static void OnOrderAssigned(object sender, OrderEventArgs e)
{
    Console.WriteLine($"Event: Order {e.Order.OrderId} has been assigned to {e.Employee.Name}.");
}

Employee waiter = new Employee(1, "Alice", Positions.Waiter, "9:00-18:00");
Employee cook = new Employee(2, "Bob", Positions.Cook, "10:00-19:00");

// Підписка на подію
waiter.OrderAssigned += OnOrderAssigned;
cook.OrderAssigned += OnOrderAssigned;

// Створення меню
MenuItem pizza = new MenuItem(1, "Pizza", "Delicious Italian pizza", 10.99m, true);
MenuItem salad = new MenuItem(2, "Salad", "Fresh vegetable salad", 5.49m, true);

Menu restaurantMenu = new Menu("Restaurant Menu");
restaurantMenu.AddMenuItem(pizza);
restaurantMenu.AddMenuItem(salad);

// Створення замовлення
Order order1 = new Order(101, DateTime.Now, OrderStatuses.New, Order.OrderTypes.DineIn, 0m, PaymentMethods.card);
order1.Items.Add(pizza);
order1.Items.Add(salad);
order1.CalculateTotalPrice();

// Призначення замовлення офіціанту
waiter.AssignOrder(order1);

// Створення клієнта
Client client = new Client(1, "John Doe", "123-456-7890", "john.doe@example.com");

// Управління столиками
TableManager tableManager = new TableManager();
tableManager.AddTable(1, 4, TableStatuses.available);
tableManager.AddTable(2, 2, TableStatuses.occupied);
tableManager.AddTable(3, 6, TableStatuses.reserved);

tableManager.DisplayTables();
tableManager.ReserveTable(1);
tableManager.UpdateTableStatus(2, TableStatuses.available);

// Звіт
Report report = new Report(DateTime.Now);
report.AddItemToReport("Pizza", 1);
report.AddItemToReport("Salad", 1);

Console.WriteLine("Sales Report:");
Console.WriteLine($"Date: {report.ReportDate}");
foreach (var item in report.Items)
{
    Console.WriteLine($"{item.Key}: {item.Value} sold");
}
    
