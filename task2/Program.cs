namespace task2;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Уявіть, що ви пишете програму для Автостанції і вам необхідно створити просту
 * колекцію автомобілів з такими даними: марка автомобіля, модель, рік випуску, колір.
 * А також другу колекцію з моделлю автомобіля, ім'ям покупця та його номером телефону.
 * Використовуючи найпростіший запит LINQ, виведіть на екран інформацію про покупця
 * одного з автомобілів і повну характеристику придбаної ним моделі. 
 */
class Program
{
    static void Main(string[] args)
    {
        List<InformCar> cars = new List<InformCar>
        {
            new InformCar{Mark = "BMW",Model = "3",Color = "Bleck",Date = 2021},
            new InformCar {Mark = "Dodge",Model = "Durango",Color = "red",Date = 2020},
            new InformCar{Mark = "Ford", Model = "Focus",Color = "Silver",Date = 1930}
        };
        List<BuyerCar> buyers = new List<BuyerCar>
        {
            new BuyerCar{Buyer = "Vasa",Car = "Durango",Nomber = "032-444-455-365"},
            new BuyerCar{Buyer = "Tom",Car = "Focus",Nomber = "032-321-444-321"}
        };
        
        Console.WriteLine("Введіть імя покупця");
        
        string name = Console.ReadLine();
        var query = from buyer in buyers
            where buyer.Buyer == name
            join car in cars on buyer.Car equals car.Model
            select new
            {
                buyer.Buyer,
                buyer.Nomber,
                car.Mark,
                car.Model,
                car.Color,
                car.Date,
            };
        foreach (var car in query)
        {
            Console.WriteLine(new string('-',50));
            Console.WriteLine(car.Buyer);
            Console.WriteLine(car.Nomber);
            Console.WriteLine(car.Mark);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Date);
            Console.WriteLine(car.Color);
        }
    }
}