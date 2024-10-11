using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Bussines
{
    public class Beer: Drink, ISalable, ISend
    {
        private const string Category = "BEER";
      
        private decimal _alcohol; // convention for private
        public string Name { get; set; } // property
        protected decimal Price { get; set; } // only for class father and childs, currently in program.cs not is posible 

        public static int QuantityObjects;
        public decimal description { get; set; } // field
        public decimal Alcochol
        {
            get { return _alcohol; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _alcohol = value;
            }
        }
        public string SAlcohol
        {
            get
            {
                return "Alcohol: " + _alcohol.ToString();
            }
        }
        public Beer(string name, decimal price, decimal alcohol, int quantity)
            :base(quantity)
        {
            Name = name;
            Price = price;
            Alcochol = alcohol;
            QuantityObjects++;
        }
        //method beaciouse is enter classs
        public virtual string GetInfo()
        {
            return "Name: " + Name + " Price: $ " + Price + " Alcohol: " + Alcochol;
        }
        public string GetInfo(string message) 
        {
            return message+ " "+ GetInfo();
        }

        public string GetInfo(int number) 
        {
            return number + ".- "+ GetInfo();
        }

        public override string GetCategory() 
        {
            return Category;
        }

        public decimal GetPrice() => Price;

        public void Send() => Console.WriteLine("Sent successfully: " + GetInfo());

    }
}
