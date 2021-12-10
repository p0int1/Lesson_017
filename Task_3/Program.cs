using System;
using System.Collections.Generic;

//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Используя динамические и анонимные типы данных, создайте
//Англо-Русский словарь на 10 слов и выведите на экран его содержание. 

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
                               {
                                  {new {Eng = "week"},       new {Rus = "неделя"}},
                                  {new {Eng = "night"},      new {Rus = "ночь"}},
                                  {new {Eng = "world"},      new {Rus = "мир"}},
                                  {new {Eng = "school"},     new {Rus = "школа"}},
                                  {new {Eng = "point"},      new {Rus = "точка"}},
                                  {new {Eng = "water"},      new {Rus = "вода"}},
                                  {new {Eng = "power"},      new {Rus = "сила"}},
                                  {new {Eng = "place"},      new {Rus = "место"}},
                                  {new {Eng = "money"},      new {Rus = "деньги"}},
                                  {new {Eng = "friend"},     new {Rus = "друг"}}

                               };
            foreach (var item in dictionary)
            {
                //Console.WriteLine("{0} - {1}", item.Key, item.Value);
                Console.WriteLine("{0} - {1}", item.Key.Eng, item.Value.Rus);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
