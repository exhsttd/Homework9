using System;
using HomeWork9.classes;
using HomeWork9.Enums;
using HomeWork9.interfaces;

namespace HomeWork9
{
    public class Program
    {
        public static void Main()
        {
            Task1(); // Упр. 10.1 Написать программу, демонстрирующую функционирование классов ACipher,BCipher.
            Task2(); // Домашнее задание 10.1. Создать класс Figure для работы с геометрическими фигурами...
        }
        
        static void Task1()
        { 
            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();
            
            Console.WriteLine("Упражнение 10.1.");
            Console.WriteLine("Введите текст для шифрования (на русском языке!!):");
            string stroka = Console.ReadLine()!;
            foreach (char ch in stroka)
            {
                if (char.IsDigit(ch))
                {
                    Console.WriteLine("Ошибка! Ввведите только буквы (русские!).");
                    return;
                }
            }
            
            string aStroka1 = aCipher.Encode(stroka);
            string aStroka2 = aCipher.Decode(aStroka1);
            Console.WriteLine("ACipher:");
            Console.WriteLine("Шифрование строки : " + aStroka1);
            Console.WriteLine("Дешифрование строки: " + aStroka2);
            
            string bStroka1 = bCipher.Encode(stroka);
            string bStroka2 = bCipher.Decode(bStroka1);
            Console.WriteLine("\nBCipher:");
            Console.WriteLine("Шифрование строки: " + bStroka1);
            Console.WriteLine("Дешифрование строки: " + bStroka2);
            Console.WriteLine();
        }

        static void Task2()
        {
            Console.WriteLine("Домашнее задание 10.1."); //Метод вывода на экран должен выводить состояние всех полей объекта.
            Figure point = new Point(2, 3, Colors.Red, Visibility.Visible);
            point.Output();
            point.Move(1, -1);
            point.Output();

            Figure circle = new Circle(3, 4, 5, Colors.Blue, Visibility.Invisible);
            circle.Output();
            circle.ChangeColor(Colors.Green);
            circle.Output();

            Figure rectangle = new Rectangle(4, 5, 1, 1, Colors.Yellow, Visibility.Visible);
            rectangle.Output();
            rectangle.Move(1, 1);
            rectangle.Output();
            
        }
    }
}