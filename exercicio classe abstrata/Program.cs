using System;
using exercicio_classe_abstrata.Entities;
using System.Collections.Generic;
namespace exercicio_classe_abstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.WriteLine("Enter the number of shapes: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Rectangle or Circle (r/c)? ");
                char op = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (op == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(color,width, heigth));
                }
                else if (op == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(color,radius));
                }
            }
            foreach (Shape x in list)
            {
                x.Area();
            }
            Console.WriteLine("SHAPE AREAS: ");
        }
    }
}
