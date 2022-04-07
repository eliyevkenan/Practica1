using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Utils.Exceptions;

namespace Entities
{
    public class Store:IEnumerable
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public List<Game> Games { get; set; }=new List<Game>();
        public void AddGame(Game game)    
        {
            if (Games.Exists(x => x.Name == game.Name))
            {
                throw new AlreadyExistsException("Xeta");
            }
                Games.Add(game);

           
        }
        public Game GetGamById(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException("Xeta");
            }
            var result =Games.Find(x=>x.Id==id);
            if (result==null)
            {
                throw new NullReferenceException("Xeta");
            }
            return result;
        }
        public Game RemoveGameById(int? id)
        {
            if (id==null)
            {
                throw new NotFoundException("Xeta");
            };
            var result=Games.Find(x=>x.Id==id);
            if (result==null)
            {
                throw new NotFoundException("Xeta");
            }
            return result;
           
        }
        public List<Game> FilterGamesByPrice(int min,int max)
        {
            List<Game> game = new List<Game>();
            var result = game.FindAll(x => x.Price > min && x.Price < max);
            if (result==null)
            {
                throw new NotFoundException("Xeta");
            }
            return result;
        }
        public List<Game> FFilterGamesByDiscountedPrice(int min, int max)
        {
           
            var result=Games.FindAll(x=>x.DiscountedPrice>min && x.DiscountedPrice < max);
            if (result==null)
            {
                throw new NotFoundException("Xeta");
            }
            return result;
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in Games)
            {
                yield return item.ShowInfo();
            }
        }
    }
}
