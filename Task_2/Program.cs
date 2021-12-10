using System;
using System.Collections.Generic;
using System.Linq;

//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую 
//коллекцию автомобилей со следующими данными: марка автомобиля, модель, год выпуска, цвет.
//А также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона. 
//Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из 
//автомобилей и полную характеристику приобретенной им модели. 

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var listCars = new List<Car>
                               {
                                   new Car("Toyota", "Corolla", 2005, "red"),
                                   new Car("Reno", "Logan", 2010, "black"),
                                   new Car("Skoda", "Octavia", 2009, "yellow"),
                                   new Car("Ford","Fiesta", 2008, "grey"),
                                   new Car("Opel","Antara", 2012, "green")
                               };

            var listClients = new List<Сlient>
                               {
                                   new Сlient( "Butev","Corolla", "0509864578"),
                                   new Сlient( "Stolpakov", "Octavia", "0509876545"),
                                   new Сlient( "Dinec", "Fiesta", "0504789863"),
                                   new Сlient( "Sisoev", "Logan", "0679445091"),
                                   new Сlient( "Stolpakov", "Antara", "0509876545")
                               };

            foreach (var item in listCars)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 30));

            foreach (var item in listClients)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 30));
            Console.Write("Введите клинета: ");
            string fio = Console.ReadLine();

            var query = from client in listClients
                        join car in listCars
                        on client.Model equals car.Model
                        where client.Name == fio
                        orderby client.Name // ascending - по возрастанию | descending - по убыванию.
                        select new
                        {
                            Name = client.Name,
                            Tel = client.Tel,
                            Marka = car.Marka,
                            Model = car.Model,
                            Year = car.Year,
                            Color = car.Color
                        };

            if (!query.Any())
                Console.WriteLine("Клиент не найден");

            foreach (var item in query)
            {
                Console.WriteLine($"Клиент: {item.Name}\nТелефон: {item.Tel}\nМарка: {item.Marka}\n" +
                    $"Модель: {item.Model}\nГод выпуска: {item.Year}\nЦвет авто:{item.Color}");
            }
            Console.ReadKey();
        }
    }
}
