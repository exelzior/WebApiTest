using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class Order
    {
        public int Id { get; set; }
        public Sandwich Sandwich { get; set; }
        public List<Extra> Extras { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
