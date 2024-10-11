using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Bussines
{
    public class ExpiringBeer: Beer
    {
        public DateTime Expiration { get; set; }
        //public string GetInfoEx()
        //{
        //    return "Name: " + Name + " Price: $ " + Price + " Alcohol: " + Alcochol+ " Date: "+ Expiration;
        //}
        public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expiration, int quantity)
            :base(name, price, alcohol, quantity) 
        {
            Expiration = expiration;
        }

        public override string GetInfo()
        {
            return "Beer witrh cadeuce_ "+ "Name: " + Name + " Price: $ " + Price + " Alcohol: " + Alcochol;
        }
    }
}
