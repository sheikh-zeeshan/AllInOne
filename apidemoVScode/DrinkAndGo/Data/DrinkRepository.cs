using DrinkAndGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data
{
    public interface IDrinkRepository
    {
        List<Drink> Drinks();
        List<Drink> PrefferedDrinks();

        Drink GetById(int id);
    }
    public class DrinkRepository : IDrinkRepository
    {
        List<Category> Categories;
        List<Drink> drinks;
        public DrinkRepository()
        {
            Categories = new CategoryRepository().Categories();
            drinks= new List<Drink> {
            new Drink {
                Name="Beer", Price=7.32m, ShortDescription="widely consumed alcohol", LongDescription="world mmmmmmmmmm" ,
                ImageURL="http://url.com", ImageThumbnailURL ="http://url2.com", InStock=true, IsPrefferedDrink=true
            , DrinkId=1, Category= Categories.First()},
             new Drink {
                Name="Rum & Coke", Price=17.3m, ShortDescription="cocktail made of soda,lime and rum", LongDescription="world ddddd" ,
                ImageURL="http://url.com", ImageThumbnailURL ="http://url2.com", InStock=true, IsPrefferedDrink=false
              , DrinkId=2, Category= Categories.First()}
            };
        }
        public List<Drink> Drinks()
        {
            return drinks;
        }
        public List<Drink> PrefferedDrinks() { return drinks.Where(x => x.IsPrefferedDrink == true).ToList(); }

        public Drink GetById(int id)
        {
            return drinks.SingleOrDefault(x => x.DrinkId == id);
        }
    }

    public interface ICategoryRepository
    {
        List<Category> Categories();
    }

    public class CategoryRepository: ICategoryRepository
    {
        public List<Category> Categories()
        {
            return new List<Category> { 
                new Category { CategoryId=1, Name="Alcohol" , Description="all alcoholic drinks"},
                new Category { CategoryId=2, Name="Non-Alcohol" , Description="all non alcoholic drinks"}
            };
        }
    }
}
