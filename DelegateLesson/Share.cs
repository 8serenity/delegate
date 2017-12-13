using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Share
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Share(double price)
        {
            Price = price;
        }

    }
}
