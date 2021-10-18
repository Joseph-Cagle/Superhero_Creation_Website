using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace superHero.Models
{
    public class allHeros
    {
        //using static because more then 1 person could connet todata base, will update one at a time
        private static List<heroInfo> hero = new List<heroInfo>();
        public static IEnumerable<heroInfo> ListOrders
        {
            get { return hero; }
        }
        public static void AddHero(heroInfo newHero)
        {
            hero.Add(newHero);
        }
    }
}

