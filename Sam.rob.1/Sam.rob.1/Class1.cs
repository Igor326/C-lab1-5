using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.rob._1
{
    class Liquor
    {
        string name;
        public double price;
        public int endurance;
        public string krainavyrobnyk;
        public double volume;
        /*конструкторы*/
        public Liquor(string n, double p, int end, string prodCountry, double vol) {
            name = n;
            price = p;
            endurance = end;
            krainavyrobnyk = prodCountry;
            volume = vol;
        }
        public Liquor() { }
        
        
        public void Info()
        {
            Console.WriteLine("Название - {0}, цена - {1}$, выдержка - {2} месяцев, страна-производитель - {3}, обьём - {4}л. ", name, price, endurance, krainavyrobnyk, volume) ;
        }
    }
}
