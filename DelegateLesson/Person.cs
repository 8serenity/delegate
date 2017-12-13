using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Person
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public List<Share> PersonalShares { get; set; }

        public Person()
        {
            Balance = 100;
        }



    }
}
