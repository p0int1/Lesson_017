using System;
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Создайте  класс  Calculator, методы  которого  принимают  аргументы  и  возвращают  значения  типа 
//dynamic.  

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int operand1 = 20, operand2 = 13;

            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, calculator.Add(operand1, operand2));
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, calculator.Sub(operand1, operand2));
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, calculator.Mul(operand1, operand2));
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, calculator.Div(operand1, operand2));

            // Delay.
            Console.ReadKey();

        }
    }
}
