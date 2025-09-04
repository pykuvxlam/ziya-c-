//using System;

//class Program
//{
//    static void Main()
//    {

//        Console.Write("Введите число: ");
//        string input = Console.ReadLine();
//        int number = int.Parse(input);

//        int result = Square(number);
//        Console.WriteLine($"Квадрат числа: {result}");
//    }

//    static int Square(int number)
//    {
//        return number * number;
//    }
//}

//Console.Write("Введите ваше имя:");
//string name= Console.ReadLine();



//Console.WriteLine($"Привет, как настроение? w? {name}!");



//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите имя: ");
//        string name = Console.ReadLine();
//        PrintName(name);

//        int number;
//        while (true)
//        {
//            Console.Write("Введите число: ");
//            string input = Console.ReadLine();

//            if (int.TryParse(input, out number))
//            {
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Ошибка: введено не число. Попробуйте ещё раз.");
//            }
//        }

//        int result = Square(number);
//        Console.WriteLine($"Квадрат числа: {result}");
//    }

//    static void PrintName(string name)
//    {
//        Console.WriteLine($"Привет, {name}!");
//    }

//    static int Square(int x)
//    {
//        return x * x;
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите первое число: ");
//        int a = int.Parse(Console.ReadLine());

//        Console.Write("Введите второе число: ");
//        int b = int.Parse(Console.ReadLine());

//        int max = MaxNumber(a, b);

//        Console.WriteLine("Большее число: " + max);
//    }

//    static int MaxNumber(int a, int b)
//    {
//        if (a > b)
//        {
//            return a;
//        }
//        else
//        {
//            return b;
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число для проверки: ");
//        int number = int.Parse(Console.ReadLine());

//        bool result = IsEven(number);

//        Console.WriteLine("Число " + number + " чётное? " + result);
//    }

//    static bool IsEven(int n)
//    {
//        if (n % 2 == 0)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите первое число: ");
//        int x = int.Parse(Console.ReadLine());

//        Console.Write("Введите второе число: ");
//        int y = int.Parse(Console.ReadLine());

//        int max = MaxNumber(x, y);
//        Console.WriteLine("Максимум из " + x + " и " + y + " это: " + max);

//        Console.Write("Введите число для проверки на чётность: ");
//        int number = int.Parse(Console.ReadLine());

//        bool evenCheck = IsEven(number);
//        Console.WriteLine("Число " + number + " чётное? " + evenCheck);
//    }

//    static int MaxNumber(int a, int b)
//    {
//        if (a > b)
//        {
//            return a;
//        }
//        else
//        {
//            return b;
//        }
//    }

//    static bool IsEven(int n)
//    {
//        if (n % 2 == 0)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число для вычисления факториала: ");
//        int number = int.Parse(Console.ReadLine());

//        int result = Factorial(number);

//        Console.WriteLine("Факториал числа " + number + " равен: " + result);
//    }

//    static int Factorial(int n)
//    {
//        int result = 1;

//        for (int i = 1; i <= n; i++)
//        {
//            result = result * i;
//        }

//        return result;
//    }
//}



//    static void PrintName(string name)
//    {
//        Console.WriteLine($"Привет, {name}!");
//    }

//    static int Square(int number)
//    {
//        return number * number;
//    }
//}



//using System; // Подключаем базовую библиотеку для работы с консолью

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите элементы массива через пробел: "); // Просим ввести массив
//        string input = Console.ReadLine(); // Считываем строку
//        string[] parts = input.Split(' '); // Разбиваем строку по пробелам → массив строк

//        int[] numbers = new int[parts.Length]; // Создаём массив чисел нужной длины
//        for (int i = 0; i < parts.Length; i++) // Перебираем все введённые значения
//        {
//            numbers[i] = int.Parse(parts[i]); // Преобразуем строку в число
//        }

//        int sum = SumArray(numbers); // Вызываем функцию для подсчёта суммы
//        Console.WriteLine("Сумма элементов массива: " + sum); // Выводим результат
//    }

//    static int SumArray(int[] arr) // Функция принимает массив
//    {
//        int sum = 0; // Начальное значение суммы

//        foreach (int num in arr) // Перебираем все элементы массива
//        {
//            sum += num; // Прибавляем каждый элемент к сумме
//        }

//        return sum; // Возвращаем итог
//    }
//}


//using System; // Подключаем консоль

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: "); // Просим ввести строку
//        string text = Console.ReadLine(); // Считываем строку

//        string reversed = ReverseString(text); // Вызываем функцию переворота
//        Console.WriteLine("Перевёрнутая строка: " + reversed); // Выводим результат
//    }

//    static string ReverseString(string s) // Функция принимает строку
//    {
//        char[] chars = s.ToCharArray(); // Превращаем строку в массив символов
//        Array.Reverse(chars); // Переворачиваем массив символов
//        return new string(chars); // Создаём строку из перевёрнутого массива
//    }
//}



//using System; // Подключаем консоль

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число для проверки: "); // Просим число
//        int number = int.Parse(Console.ReadLine()); // Читаем и преобразуем в int

//        bool isPrime = IsPrime(number); // Проверяем через функцию
//        Console.WriteLine("Число " + number + " простое? " + isPrime); // Выводим результат
//    }

//    static bool IsPrime(int n) // Функция проверки простоты числа
//    {
//        if (n <= 1) return false; // 0 и 1 — не простые
//        if (n == 2) return true; // 2 — простое
//        if (n % 2 == 0) return false; // чётные больше 2 — не простые

//        for (int i = 3; i * i <= n; i += 2) // Перебираем только нечётные делители
//        {
//            if (n % i == 0) return false; // Нашли делитель — число составное
//        }

//        return true; // Делителей нет — число простое
//    }
//}
