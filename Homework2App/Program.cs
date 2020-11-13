using System;

namespace Homework2App
{
    class Program
    {
        static void Main()
        {
            //Разборка числа на разряды и определение максимальной и минимальной цифр
            while (true)
            {
                Console.WriteLine("Введите пяизначное число");
                bool result1 = int.TryParse(Console.ReadLine(), out int usernumber);
                if (result1)
                {
                    if (usernumber > 9999 && usernumber <= 99999)
                    {
                        int divider = 10000;
                        int MaxNumber = 0;
                        int MinNumber = 9;

                        for (int i = 1; i<=5; i++)
                        {
                            int digit = (usernumber - (usernumber % divider)) / divider; 
                            usernumber = usernumber - (digit * divider);
                            divider = divider / 10;
                            Console.WriteLine(i + " цифра равна" + digit);
                            if (MaxNumber < digit)
                            { MaxNumber = digit; }
                            else if (MinNumber > digit)
                                    { MinNumber = digit; }
                            else continue;

                        }
                        Console.WriteLine("Наибольшее число: " + MaxNumber);
                        Console.WriteLine("Наименьшее число: " + MinNumber);
                        
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не пятизначное число");
                    }

                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                }
                
            }

            //Калькулятор
            int a = 1;
            double ResultOp = 0;
            while (a>0)
            { 
                double number1 = ResultOp;
                if (a == 1)
                {
                    Console.WriteLine("Добро пожаловать в калькулятор!");
                    Console.WriteLine("Вводим первое число: ");
                    bool result2 = double.TryParse(Console.ReadLine(), out number1);
                    if (result2 == false)
                    {
                        Console.WriteLine("Вы ввели не число");
                        continue;
                    }
                }
                else Console.WriteLine("Первое число (Результат  предыдущей операции): "+number1);

                
                Console.WriteLine("Вводим второе число: ");
                bool result3 = double.TryParse(Console.ReadLine(), out double number2);
                if (result3 == false)
                {
                    Console.WriteLine("Вы ввели не число");
                    continue;
                }
                Console.WriteLine("Вводим операцию: ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Результат: " + (number1 + number2));
                        ResultOp = number1 + number2;
                        break;
                    case "-":
                        Console.WriteLine("Результат: " + (number1 - number2));
                        ResultOp = number1 - number2;
                        break;
                    case "*":
                        Console.WriteLine("Результат: " + (number1 * number2));
                        ResultOp = number1 * number2;
                        break;
                    case "/":
                        Console.WriteLine("Результат: " + (number1 / number2));
                        ResultOp = number1 / number2;
                        break;
                    case "pow":
                        Console.WriteLine("Результат: " + Math.Pow(number1, number2));
                        ResultOp = Math.Pow(number1, number2);
                        break;
                    case "sqrt":
                        Console.WriteLine("Результат: " + Math.Sqrt(number1));
                        ResultOp = Math.Sqrt(number1);
                        break;
                }
                Console.WriteLine("Сдедующий шаг?");
                string choice = Console.ReadLine();
                if (choice == "Y")
                {
                    a = 2;
                    Console.WriteLine("Продолжаем");
                    continue;
                }
                else if (choice == "R")
                {
                    a = 1;
                    Console.WriteLine("Заново");
                    continue;
                }
                else if (choice == "N")
                {
                    Console.WriteLine("Конец работы");
                    break;
                }    
  

            }
        }
    }
}
