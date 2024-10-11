using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Bussines
{
    public class Wine : Drink
    {
        private const string Category = "WINE";
        public Wine(int quantity) : base(quantity) 
        {

        }
        public override string GetCategory() => Category;
    }
}
