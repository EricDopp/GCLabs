using JoiningDataPart1;

Order order1 = new Order();
order1.Customer = "Acme Hardware";
order1.Item = "Mouse";
order1.Price = 25;
order1.Quantity = 3;

Order order2 = new Order();
order2.Customer = "Acme Hardware";
order2.Item = "Keyboard";
order2.Price = 45;
order2.Quantity = 2;

Order order3 = new Order();
order3.Customer = "Falls Realty";
order3.Item = "Macbook";
order3.Price = 800;
order3.Quantity = 2;

Order order4 = new Order();
order4.Customer = "Julie's Morning Diner";
order4.Item = "iPad";
order4.Price = 525;
order4.Quantity = 1;

Order order5 = new Order();
order5.Customer = "Julie's Morning Diner";
order5.Item = "Credit Card Reader";
order5.Price = 45;
order5.Quantity = 1;

List<Order> list = new List<Order>();
list.Add(order1);
list.Add(order2);
list.Add(order3);
list.Add(order4);
list.Add(order5);

var orderTable = from order in list
                 group order by order.Customer;


foreach (var items in orderTable)
{
    Console.WriteLine($"{items.Key}");
    Console.WriteLine($"\tItem\t\tPrice\tQuantity\tTotal");
    foreach (var item in items)
    {
        Console.WriteLine($"\t{item.Item}\t\t{item.Price}\t{item.Quantity}\t{item.Price * item.Quantity}");
    }
    Console.WriteLine();
}

foreach (var items in orderTable)
{
    decimal totalCost = 0;
    Console.WriteLine($"{items.Key}");
    Console.WriteLine($"\tItem\t\tPrice\tQuantity\tTotal");
    foreach (var item in items)
    {
        decimal itemTotal = item.Price * item.Quantity;
        totalCost += itemTotal;
        Console.WriteLine($"\t{item.Item}\t\t{item.Price}\t{item.Quantity}\t{item.Price * item.Quantity}");
    }
    Console.WriteLine($"\tTotal\t\t\t{totalCost}");

}

var orderTable2 = from order in list
                  group order by order.Customer into customerGroup
                  select new
                  {
                      Customer = customerGroup.Key,
                      Orders = customerGroup.ToList(),
                      TotalCost = customerGroup.Sum(item => item.Price * item.Quantity)
                  };
foreach (var customerInfo in orderTable2)
{
    Console.WriteLine($"Customer\tItem\tPrice\tQuantity\tTotal");
    Console.Write($"{(customerInfo.Customer)}");

    foreach (var orderItem in customerInfo.Orders)
    {
        Console.WriteLine($"\t{orderItem.Item}\t{orderItem.Price.ToString("0.00")}\t{orderItem.Quantity.ToString()}");
    }
    Console.WriteLine();
}