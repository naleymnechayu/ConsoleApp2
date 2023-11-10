// ЗАДАНИЕ 1 Написать класс для решения квадратного уравнения. Коэффициенты уравнения и его корни
//должны быть приватными полями класса, доступ к которым осуществляется через специальные
//методы. Вычисление дискриминанта вынести в отдельный приватный метод. Вычисление
//корней производить с помощью отдельного метода void CalculateRoots(). Предусмотреть
//установку значений коэффициентов уравнения с помощью конструктора класса. Написать
//программу, решающую квадратное уравнение с помощью созданного класса.


//using System;

//class QES
//{
//    private double a, b, c;
//    private double Discriminant { get { return b * b - 4 * a * c; } }
//    private double Root1 { get; set; }
//    private double Root2 { get; set; }

//    public QES(double coefficientA, double coefficientB, double coefficientC)
//    {
//        a = coefficientA;
//        b = coefficientB;
//        c = coefficientC;
//    }

//    private void CalculateRoots()
//    {
//        if (Discriminant > 0)
//        {
//            Root1 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
//            Root2 = (-b - Math.Sqrt(Discriminant)) / (2 * a);
//        }
//        else if (Discriminant == 0)
//        {
//            Root1 = -b / (2 * a);
//            Root2 = Root1;
//        }
//        else
//        {

//            Root1 = double.NaN;
//            Root2 = double.NaN;
//        }
//    }

//    public void Solve()
//    {
//        CalculateRoots();
//        Console.WriteLine($"Корень 1: {Root1}, Корень 2: {Root2}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        QES solver = new QES(1, -3, 2);
//        solver.Solve();
//    }
//}




// ЗАДАНИЕ 2 Написать класс, у которого имеется приватное поле — n, изначально равное 0. Для установки
//значения n создать специальный метод: bool SetNumber(int number). Если устанавливаемое
//значение n равно n + 1, вернуть в качестве результата true, в противном случае обнулить n и
//вернуть false. Также добавить публичный метод, который будет возвращать ожидаемое
//значение n, т. е. n + 1. Продемонстрировать работу класса с помощью программы, которая
//просит ввести пользователя число 1, затем число 2 и так до бесконечности. Если пользователь
//введёт число не равное n + 1, то начать выполнение алгоритма заново.


//class IncrementalNumberChecker
//{
//    private int n = 0;

//    public bool SetNumber(int number)
//    {
//        if (number == n + 1)
//        {
//            n = number;
//            return true;
//        }
//        else
//        {
//            n = 0;
//            return false;
//        }
//    }

//    public int GetExpectedNumber()
//    {
//        return n + 1;
//    }
//}

//class Programm
//{
//    static void Main()
//    {
//        IncrementalNumberChecker checker = new IncrementalNumberChecker();

//        while (true)
//        {
//            Console.WriteLine($"Введите число {checker.GetExpectedNumber()}: ");
//            int input;
//            if (int.TryParse(Console.ReadLine(), out input))
//            {
//                if (checker.SetNumber(input))
//                {
//                    continue;
//                }
//                else
//                {
//                    Console.WriteLine("Неверное число. Начните заново.");
//                    break;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Введите корректное число.");
//            }
//        }
//    }
//}



// ЗАДАНИЕ 3 Написать класс, который позволяет шифровать и расшифровывать строки шифром Цезаря.
// Методы и поля класса определить самостоятельно. Продемонстрировать работу класса.


//using System;
//using System.Text;

//class CaesarCipher
//{
//    private int shift;

//    public CaesarCipher(int shift)
//    {
//        this.shift = shift;
//    }

//    public string Encrypt(string plainText)
//    {
//        StringBuilder encryptedText = new StringBuilder();

//        foreach (char c in plainText)
//        {
//            if (char.IsLetter(c))
//            {
//                char offset = char.IsUpper(c) ? 'A' : 'a';
//                encryptedText.Append((char)(((c + shift - offset) % 26) + offset));
//            }
//            else
//            {
//                encryptedText.Append(c);
//            }
//        }

//        return encryptedText.ToString();
//    }

//    public string Decrypt(string encryptedText)
//    {
//        return Decrypt(encryptedText, 26 - shift);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        CaesarCipher cipher = new CaesarCipher(3);
//        string originalText = "Hello, world!";
//        string encryptedText = cipher.Encrypt(originalText);
//        string decryptedText = cipher.Decrypt(encryptedText);

//        Console.WriteLine($"Исходный текст: {originalText}");
//        Console.WriteLine($"Зашифрованный текст: {encryptedText}");
//        Console.WriteLine($"Расшифрованный текст: {decryptedText}");
//    }
//}