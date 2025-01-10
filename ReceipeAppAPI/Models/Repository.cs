
using Microsoft.VisualBasic;

namespace ReceipeAppAPI.Models
{
    public class Repository : IRepository
    {
        private Dictionary<string, Receipe> receipies;
        private Dictionary<string, Receipe> filterReceipies;

        public Repository()
        {
            receipies = new Dictionary<string, Receipe>();
            new List<Receipe>() {
                new Receipe() {idMeal="52841",strMeal="Creamy Tomato Soup",strDrinkAlternate=null,strCategory="Starter",strArea="British",strInstructions="Put the oil, onions, celery, carrots, potatoes and bay leaves in a big casserole dish, or two saucepans. Fry gently until the onions are softened \u2013 about 10-15 mins. Fill the kettle and boil it.\r\nStir in the tomato pur\u00e9e, sugar, vinegar, chopped tomatoes and passata, then crumble in the stock cubes. Add 1 litre boiling water and bring to a simmer. Cover and simmer for 15 mins until the potato is tender, then remove the bay leaves. Pur\u00e9e with a stick blender (or ladle into a blender in batches) until very smooth. Season to taste and add a pinch more sugar if it needs it. The soup can now be cooled and chilled for up to 2 days, or frozen for up to 3 months.\r\nTo serve, reheat the soup, stirring in the milk \u2013 try not to let it boil. Serve in small bowls with cheesy sausage rolls.",strMealThumb="https://www.themealdb.com/images/media/meals/stpuws1511191310.jpg",strTags="Baking",strYoutube="https://www.youtube.com/watch?v=lBhwjjUiFk4",strIngredient1="Olive Oil",strIngredient2="Onions",strIngredient3="Celery",strIngredient4="Carrots",strIngredient5="Potatoes",strIngredient6="Bay Leaf",strIngredient7="Tomato Puree",strIngredient8="Sugar",strIngredient9="White Vinegar",strIngredient10="Chopped Tomatoes",strIngredient11="Passata",strIngredient12="Vegetable Stock Cube",strIngredient13="Whole Milk",strIngredient14="",strIngredient15="",strIngredient16="",strIngredient17="",strIngredient18="",strIngredient19="",strIngredient20="",strMeasure1="3 tbsp",strMeasure2="2 chopped",strMeasure3="2 sticks",strMeasure4="300g",strMeasure5="500g",strMeasure6="4",strMeasure7="5 tblsp ",strMeasure8="2 tblsp ",strMeasure9="2 tblsp ",strMeasure10="1\u00bd kg",strMeasure11="500g",strMeasure12="3",strMeasure13="400ml",strMeasure14="",strMeasure15="",strMeasure16="",strMeasure17="",strMeasure18="",strMeasure19="",strMeasure20="",strSource="https://www.bbcgoodfood.com/recipes/2604646/creamy-tomato-soup",strImageSource=null,strCreativeCommonsConfirmed=null,dateModified=null},
            }.ForEach(r => receipies[r.idMeal]=r);
        }

        public IEnumerable<Receipe> Receipe(string key)
        {
            filterReceipies = new Dictionary<string, Receipe>();
            foreach (var r in receipies)
            {
                if (r.Value.strMeal.Contains(key, StringComparison.OrdinalIgnoreCase) || 
                    r.Value.strCategory.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient1.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient2.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient3.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient4.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient5.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient6.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient7.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient8.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient9.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient10.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient11.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient12.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient13.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient14.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient15.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient16.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient17.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient18.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient19.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                    r.Value.strIngredient20.Contains(key, StringComparison.OrdinalIgnoreCase)
                    )
                {
                    filterReceipies[r.Key] = r.Value;
                }
            }
            return filterReceipies.Values;
        }
    }
}
