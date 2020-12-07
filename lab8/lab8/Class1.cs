using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class Garage
    {
        static public List<car> sheikCars=new List<car>();
     

        static public void AddCarToGarage(string Name, string Color, ushort Year) 
        {
            car car = new car();
            sheikCars.Add(car);
            car.name = Name;
            car.color = Color;
            car.graduationYear = Year;
            Console.WriteLine("Была добавлена машина с именем {0}, её цвет - {1}, год выпуска - {2}, её айди - {3}.", Name,Color,Year,sheikCars.IndexOf(car));
         
        }
        static public void RemoveCarFromGarage(byte id)
        {
            sheikCars.RemoveAt(id);

        }

    }
}
