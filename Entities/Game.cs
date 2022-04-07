using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace Entities
{
   public  class Game
    {
        public Game(string name,Platformenum platformenum,double price)
        {
            _id ++;
            Id = _id;
            Name = name;
            Platformenum = Platformenum;    
            Price = price;
        }
        static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public Platformenum Platformenum { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public string Publisher { get; set; }
        public bool IsDelete { get; set; }
        public string ShowInfo()
        {
            return $"Id:{Id} - Name:{Name} - Price:{Price} - Platformenum:{Platformenum}";
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public double GetDiscountedPrice()
        {
            double discountedPrice = 0;
            discountedPrice = Price / 100 * discountedPrice;
            return discountedPrice;
        }

       
    }
}
