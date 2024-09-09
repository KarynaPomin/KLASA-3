using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_dziedziczenie
{
    internal class Program
    {
        public class Shape
        {
            public virtual float CalculateArea()
            {
                return 0;
            }

            public virtual float CalculatePeripeter() 
            {
                return 0;
            }

        }

        public class Rectangle : Shape 
        {
            private float widht;
            private float height;

            public void SetDimention(float w, float h)
            {
                widht = w;
                height = h;
            }

            public override float CalculateArea()
            {
                //return base.CalcalateArea();
                return widht * height;
            }

            public override float CalculatePeripeter()
            {
                return 2 * (widht + height);
            }
        }

        public class Circle : Shape 
        {
            private float radius;

            public void SetRadius(float r)
            {
                radius = r;
            }

            public override float CalculateArea() 
            {
                return (float)Math.Round((Math.PI * radius * radius), 2);
            }

            public override float CalculatePeripeter()
            {
                return (float)Math.Round((Math.PI * radius), 2);
            }
        }

        static void Main(string[] args)
        {
            // + zabezpieczenia
            while (true)
            {
                Console.WriteLine("1. Prostokąt");
                Console.WriteLine("2. Koło");
                Console.WriteLine("3. Trójkąt");
                Console.WriteLine("4. Trapez");
                Console.WriteLine("5. Kula");
                Console.WriteLine("6. Wyjście");
                Console.WriteLine("Wybierz krztałt do obliczenia.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Rectangle rect = new Rectangle();
                        Console.Write("Podaj szerokość: ");
                        float rectWith = float.Parse(Console.ReadLine());
                        Console.Write("Podaj wysokość: ");
                        float rectHeigh = float.Parse(Console.ReadLine());
                        rect.SetDimention(rectWith, rectHeigh);
                        Console.WriteLine("Powierzchnia prostokąta: {0}", rect.CalculateArea());
                        Console.WriteLine("Obwód prostokąta: {0}", rect.CalculatePeripeter());
                        Console.WriteLine();
                        break;
                    case 2:
                        Circle circle = new Circle();
                        float circleRadius = GetValidInput("Podaj radius: ");
                        circle.SetRadius(circleRadius);
                        Console.WriteLine("Powierzchnia kolą: {0}", circle.CalculateArea());
                        Console.WriteLine("Obwód koła: {0}", circle.CalculatePeripeter());
                        Console.WriteLine();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór!");
                        break;
                }
            }
        }
        private static float GetValidInput(string prompt)
        {
            float result;
            while (true)
            {
                Console.Write(prompt);
                if (float.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawiedłowe dane. Spróbuj ponownie.");
                    Console.ResetColor();
                }
            }
        }
    }
}
