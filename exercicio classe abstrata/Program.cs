using System;
using exercicio_classe_abstrata.Entities;
using System.Collections.Generic;
using System.Globalization;
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
                Color color = Enum.Parse<Color>(Console.ReadLine().ToLower());
                if (op == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(color,width, heigth));
                }
                else if (op == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color,radius));
                }
            }
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape x in list)
            {               
                Console.WriteLine(x.Area().ToString("F2"));
            }
          
            
        }
    }
    
}
