using System;
using System.Collections.Generic;

namespace lr3
{

    class Program
    {
        static void Main()
        {
            List<Interface1> operations = new List<Interface1>
        {
            new OrOperation(),
            new AndOperation(),
            new XorOperation()
        };

            Console.WriteLine("Доступные операции:");
            foreach (var operation in operations)
            {
                Console.WriteLine($"{operation.GetOperationSign()} - {operation.GetOperationName()}");
            }

            Console.WriteLine("Введите 1 для ИЛИ, 2 для И, 3 для ИСКЛЮЧАЮЩЕГО ИЛИ:");
            int choice = int.Parse(Console.ReadLine() ?? "1");

            Console.WriteLine("Введите первое значение (true/false):");
            bool firstValue = bool.Parse(Console.ReadLine() ?? "false");

            Console.WriteLine("Введите второе значение (true/false):");
            bool secondValue = bool.Parse(Console.ReadLine() ?? "false");

            Interface1 selectedOperation = operations[choice - 1];
            bool result = selectedOperation.Execute(firstValue, secondValue);

            Console.WriteLine($"Результат операции {selectedOperation.GetOperationSign()}: {result}");
        }
    }
}