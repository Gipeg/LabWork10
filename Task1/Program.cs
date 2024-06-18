using Task1; // реп контора хулиганов
{
    Order orders = new Order();
    orders.Print();
    Console.WriteLine("_____________");

    Console.WriteLine("Operators:"); //вывод операторов

    Order order1 = new() { _Summ = 0 };
    Console.WriteLine(order1._Summ);
    order1.Print();

    Console.WriteLine("________________________________"); //вывод заказа
    Order order2 = new() { _Summ = 2000, _Address = "ул. Пушкина д. Колотушкино", _Name = "Илья" };
    Order order3 = new() { _Summ = 500 };
    Console.WriteLine(order2._Summ);
    Console.WriteLine(order3._Summ);

    //Console.WriteLine("________________________________");
    //Console.WriteLine("Не отсортированный массив");
    //PrintOrder(orders);

    //Console.WriteLine("\nОтсортированный массив: ");
    //PrintOrder(orders);

    //static void PrintOrder(Order[] order)
    //{
    //    foreach (var order in orders)
    //    {
    //        Console.WriteLine($"Имя {order.Name}, Адрес {order.Address}, Сумма {order.Summ}");
    //    }
    //}
}