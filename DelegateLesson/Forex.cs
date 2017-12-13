using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Forex
    {
        public List<Person> Players { get; set; }
        public List<Share> Shares { get; set; }
        public int CountPlayers { get; set; }
        public double CountShares { get; set; }
        public double DefaultPrice { get; set; }



        public Forex()
        {
            Players = new List<Person>();
            Shares = new List<Share>();
            CountPlayers = 10;
            CountShares = 1000;
            for(int i = 0; i < CountPlayers; i++)
            {
                Players.Add(new Person());
            }
            for(int i = 0; i < CountShares; i++)
            {
                Shares.Add(new Share(DefaultPrice));
            }
        }

        public void Buy(Person buyer, double summ)
        {

            if ((buyer.Balance >= summ))
            {
                for (int j = 0; j < summ / DefaultPrice; j++)
                {
                    buyer.PersonalShares.Add(new Share(DefaultPrice));
                    Shares.RemoveAt(Shares.Count - 1);
                }
                buyer.Balance -= summ;
                CountShares -= summ / DefaultPrice;
            }

        }

        public void Sell(Person seller,double summ)
        {
            if (seller.Balance >= summ)
            {
                for(int i = 0; i < summ / DefaultPrice; i++)
                {
                    seller.PersonalShares.RemoveAt(0);
                    Shares.Add(new Share(DefaultPrice));
                }
                seller.Balance += summ;

            }
        }



    }
}
