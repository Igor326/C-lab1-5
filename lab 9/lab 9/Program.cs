using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Picture picture = new Picture();
            picture.AddShape(new Triangle("triangle1"));
            picture.AddShape(new Triangle("triangle2"));

            picture.AddShape(new Square("square1", 10, 3));

            picture.AddShape(new Circle("circle1"));
            picture.AddShape(new Circle("circle2", 2));
            picture.AddShape(new Circle("circle3", 5, 2));

            picture.Draw();
            Console.WriteLine();

            picture[2].Draw();
            Console.WriteLine();

            picture.RemoveShape("square1", "Square", 20);
            Console.WriteLine();

            picture[2].Draw();

            Console.ReadKey();
        }
    }
}
