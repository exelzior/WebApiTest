using AppModels;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class Sandwichs : ISandwichs
    {
        List<Sandwich> sandwichList = new List<Sandwich> { 
            new Sandwich{ Name = "X Burger", Cost = 5M },
            new Sandwich{ Name = "X Egg", Cost = 4.5M },
            new Sandwich{ Name = "X Bacon", Cost = 7M },
        };

        public List<Sandwich> GetSandwich() {
            return sandwichList;
        }
    }
}
