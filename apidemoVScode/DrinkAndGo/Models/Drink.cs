using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string  ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public bool IsPrefferedDrink  { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string LongDescription { get; internal set; }
        public string ImageThumbnailURL { get; internal set; }
    }
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Drink> Drinks { get; set; }
    }
}
