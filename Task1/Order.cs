namespace Task1
{
    public class Order  //имена компонентов класса
    {
        public string _Name { get; set; }
        public string _Address { get; set; }
        public int _Summ { get; set; }

        public Order() //первоначальный класс
           : this("Неизвестна", "Неизвестен", 0) { }

        public Order(string Name, string Address, int Summ) //присваивание переменным служебные имена
        {
            _Name = Name;
            _Address = Address;
            _Summ = Summ;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;

            Order other = obj as Order;
            if (other == null)
            {
                return this._Summ.CompareTo(this);
            }
            else
            {
                throw new ArgumentException("Нет Заказов");
            }
        }


        //рассчёты операторов
        public static bool operator &(Order a, Order b) => a._Summ == b._Summ;

        public static bool operator ^(Order a, Order b) => a._Summ != b._Summ;

        public static bool operator true(Order order) => order._Summ >= 0;

        public static bool operator false(Order order) => order._Summ < 0;

        public void Print() //вывод класса
        {
            Console.WriteLine($"Заказ: {_Name}, адрес: {_Address}, Сумма: {_Summ}");
        }
    }
}
