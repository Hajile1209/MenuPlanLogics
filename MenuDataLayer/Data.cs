using MenuModel;
namespace MenuDataLayer
{
    public class Data
    {
        public List<Menu> menus = new List<Menu>();
        
        public Data()
        {
            MenuData();
        }
        public void MenuData()
        {
            //1-9 Bulking, 10-18 Cutting
            Menu menu1 = new Menu();
            menu1.meal = "Breakfast";
            menu1.dish = "Protein-Packed Break Burrito \n Ingredients: \nLarge whole wheat tortilla \n3 eggs \n1/2 cup cooked black beans\n1/4 cup shredded cheddar cheese \n1/4 cup diced bell peppers \n1/4 cup diced onions \nSalt and pepper to taste";
            menu1.beverage = "Water \nOrange juice \nMilk \nProtein shake";
            menu1.preference = "Hot sauce or salsa for extra flavor \nGuacamole for topping \nSour cream for creaminess";
            menu1.nutrition = "Calories: 500-600 \nCarbohydrates: 40-50 grams \nProtein: 30-35 grams \nFat: 20-25 grams";
            menu1.time = "7:30AM - 8:30AM";
            menus.Add(menu1);

            Menu menu2 = new Menu();
            menu2.meal = "Lunch";
            menu2.dish = "Grilled Chicken Quinoa Salad \nIngredients: \n 1 pc.Grilled chicken breast, sliced \n 1cup Cooked quinoa \n 2 cups Mixed greens (lettuce, spinach, arugula) \n 1 Cup Cherry tomatoes, halved \n 1/2 Cucumber, sliced \n 1/4 Red onion, thinly sliced \n 1/4 Feta cheese, crumbled \nBalsamic vinaigrette dressing ";
            menu2.beverage = "Water \nIced tea \nLemonade \nFruit-infused water";
            menu2.preference = "Avocado slices \nGrilled vegetables (bell peppers, zucchini) \nHummus for dipping";
            menu2.nutrition = "Calories: 400-500 \nCarbohydrates: 30-40 grams \nProtein: 30-35 grams \nFat: 15-20 grams";
            menu2.time = "11:40AM - 12:40PM";
            menus.Add(menu2);

            Menu menu3 = new Menu();
            menu3.meal = "Dinner";
            menu3.dish = "Grilled Steak with Baked Potato and Steamed Broccoli \n Ingredients:\n8 oz (226g) steak (such as sirloin or ribeye) \n1 large baked potato (200g) \n1 cup (150g) steamed broccoli florets \nOlive oil \nSalt and pepper";
            menu3.beverage = "Water \nHerbal tea \nSparkling water with lemon";
            menu3.preference = "Garlic butter sauce for the steak \nSour cream and chives for the baked potato";
            menu3.nutrition = "Calories: 600-700 \nCarbohydrates: 40-50 grams \nProtein: 40-50 grams \nFat: 25-30 grams";
            menu3.time = "5:00PM - 6:00PM";
            menus.Add(menu3);

            Menu menu4 = new Menu();
            menu4.meal = "Breakfast";
            menu4.dish = "High-Protein Oatmeal \nIngredients: \n1 cup rolled oats \n1 cup milk (dairy or plant-based) \n1 scoop protein powder (whey, casein, or plant-based) \n1 tablespoon almond butter or peanut butter \n1 sliced banana ";
            menu4.beverage = "Water \nAlmond milk \nCoffee \nFruit smoothie";
            menu4.preference = "Optional toppings: chopped nuts, seeds, berries, honey \nMaple syrup for sweetness \nCinnamon for flavor \nGreek yogurt for added protein";
            menu4.nutrition = "Calories: 400-500\r\nCarbohydrates: 45-50 grams\r\nProtein: 25-30 grams\r\nFat: 15-20 grams";
            menu4.time = "7:00AM - 8:00AM";
            menus.Add(menu4);

            Menu menu5 = new Menu();
            menu5.meal = "Lunch";
            menu5.dish = "Turkey and Avocado Wrap \nIngredients: \nWhole wheat wrap or tortilla \n 4 oz Sliced turkey breast \n 1/4 Avocado, mashed \n Handful of Spinach leaves \nSliced tomatoes \nSliced red onion";
            menu5.beverage = "Water \nGreen tea \nSparkling water with lemon \nCranberry juice";
            menu5.preference = "Pepper jack cheese \nSliced jalapeños for a spicy kick \nGreek yogurt, Mustard or Mayonnaise for dipping";
            menu5.nutrition = "Calories: 350-450 \nCarbohydrates: 25-35 grams \nProtein: 25-30 grams \nFat: 15-20 grams";
            menu5.time = "11:00AM - 12:00PM";
            menus.Add(menu5);

            Menu menu6 = new Menu();
            menu6.meal = "Dinner";
            menu6.dish = "Lemon Herb Grilled Chicken with Quinoa and Roasted Vegetables \nIngredients: \n8 oz (226g) chicken breast, marinated in lemon juice and herbs\n1 cup (185g) cooked quinoa \nAssorted roasted vegetables (bell peppers, zucchini, carrots) \nOlive oil \nSalt and pepper";
            menu6.beverage = "Iced tea \nLemonade \nFruit-infused water";
            menu6.preference = "Pesto sauce for the quinoa \nBalsamic glaze for the roasted vegetables";
            menu6.nutrition = "Calories: 500-600 \nCarbohydrates: 40-50 grams \nProtein: 35-45 grams \nFat: 15-20 grams";
            menu6.time = "5:00PM - 6:00PM";
            menus.Add(menu6);

            Menu menu7 = new Menu();
            menu7.meal = "Breakfast";
            menu7.dish = "Hearty Breakfast Hash \nIngredients: \n2 medium potatoes, diced \n1/2 onion, diced \n1 bell pepper, diced \n4 eggs \n1/4 cup shredded cheddar cheese \nSalt and pepper to taste \nCooking oil";
            menu7.beverage = "Water \nApple juice \nGreen tea \nChocolate milk";
            menu7.preference = "Ketchup or hot sauce for topping \nAvocado slices for extra creaminess \nTurkey or chicken sausage for added protein";
            menu7.nutrition = "Calories: 400-500 \nCarbohydrates: 40-50 grams \nProtein: 15-20 grams \nFat: 20-25 grams";
            menu7.time = "6:30AM - 7:30AM";
            menus.Add(menu7);

            Menu menu8 = new Menu();
            menu8.meal = "Lunch";
            menu8.dish = "Beef and Broccoli Stir-Fry \nIngredients: \n 6 oz Thinly sliced beef (such as sirloin or flank steak) \n 2 cups Broccoli florets \n 1/2 Sliced bell peppers \n 1/2 Sliced carrots \n 2 tbps. Soy sauce \n 2 cloves Garlic, minced \n 1 tsp. Ginger, grated \n 1 tsp. Sesame oil \n 1cup Cooked brown rice";
            menu8.beverage = "Water \nUnsweetened iced tea \nCoconut water \nPineapple juice";
            menu8.preference = "Sriracha or chili sauce for added heat \nCashews or peanuts for extra crunch \nSliced green onions for garnish";
            menu8.nutrition = "Calories: 400-500 \nCarbohydrates: 30-40 grams \nProtein: 25-30 grams \nFat: 15-20 grams";
            menu8.time = "11:30AM - 12:30AM";
            menus.Add(menu8);

            Menu menu9 = new Menu();
            menu9.meal = "Dinner";
            menu9.dish = "Spaghetti Bolognese with Garlic Bread \n Ingredients: \n8 oz (226g) ground beef or turkey \n1 cup (240g) tomato sauce \n2 cups (200g) cooked spaghetti \nGarlic bread (2 slices) \nOlive oil \nSalt and pepper";
            menu9.beverage = "Water \nCranberry juice \nHerbal tea";
            menu9.preference = "Grated Parmesan cheese (optional) \nRed pepper flakes for heat";
            menu9.nutrition = "Calories: 600-700 \nCarbohydrates: 60-70 grams \nProtein: 25-35 grams \nFat: 25-30 grams";
            menu9.time = "5:00PM - 6:00PM";
            menus.Add(menu9);

            Menu menu10 = new Menu();
            menu10.meal = "Breakfast";
            menu10.dish = "Veggie Egg White Omelette \n Ingredients: \n3 egg whites \n1/4 cup (30g) diced bell peppers \n1/4 cup (30g) diced tomatoes \n1/4 cup (30g) diced onions \nHandful of spinach leaves \nSalt and pepper to taste \nCooking spray or olive oil for cooking";
            menu10.beverage = "Water \nGreen tea \nBlack coffee";
            menu10.preference = "Salsa or hot sauce for topping";
            menu10.nutrition = "Calories: 150-200\r\nCarbohydrates: 10-15 grams\r\nProtein: 15-20 grams\r\nFat: 5-7 grams";
            menu10.time = "7:00AM - 8:00AM";
            menus.Add(menu10);

            Menu menu11 = new Menu();
            menu11.meal = "Lunch";
            menu11.dish = "Grilled Chicken Salad with Balsamic Vinaigrette \n Ingredients: \n4 oz (113g) grilled chicken breast, sliced \n2 cups (60g) mixed salad greens (lettuce, spinach, arugula) \n1/2 cup (75g) cherry tomatoes, halved \n1/4 cup (40g) sliced cucumber \n1/4 cup (30g) sliced red onion \n1 tablespoon (15ml) balsamic vinaigrette dressing";
            menu11.beverage = "Water \nSparkling water with lemon \nUnsweetened iced tea \nGreen tea";
            menu11.preference = "Light sprinkle of feta cheese for extra flavor";
            menu11.nutrition = "Calories: 250-300 \nCarbohydrates: 10-15 grams \nProtein: 25-30 grams \nFat: 10-15 grams";
            menu11.time = "12:00PM - 1:00PM";
            menus.Add(menu11);

            Menu menu12 = new Menu();
            menu12.meal = "Dinner";
            menu12.dish = "Grilled Salmon with Quinoa and Steamed Asparagus \n Ingredients: \n6 oz (170g) salmon fille r\n1/2 cup (90g) cooked quinoa \n1 cup (180g) steamed asparagus spears \nLemon wedges \nOlive oil \nSalt and pepper";
            menu12.beverage = "Water \nSparkling water with lime \nHerbal tea";
            menu12.preference = "Dijon mustard sauce for the salmon \nBalsamic glaze for the asparagus";
            menu12.nutrition = "Calories: 400-500 \nCarbohydrates: 30-40 grams \nProtein: 35-45 grams \nFat: 15-20 grams";
            menu12.time = "5:00PM - 6:00PM";
            menus.Add(menu12);

            Menu menu13 = new Menu();
            menu13.meal = "Breakfast";
            menu13.dish = "Greek Yogurt Parfait \nIngredients: \n1 cup (240g) plain Greek yogurt \n1/2 cup (80g) mixed berries (such as strawberries, blueberries, raspberries) \n1/4 cup (30g) granola";
            menu13.beverage = "Water \nHerbal tea \nUnsweetened almond milk";
            menu13.preference = "Chia seeds or flaxseeds for added fiber \nUnsweetened coconut flakes for topping";
            menu13.nutrition = "Calories: 250-300 \nCarbohydrates: 30-35 grams \nProtein: 20-25 grams \nFat: 7-10 grams";
            menu13.time = "7:30AM - 8:30AM";
            menus.Add(menu13);

            Menu menu14 = new Menu();
            menu14.meal = "Lunch";
            menu14.dish = "Turkey and Hummus Wrap \n Ingredients: \n 4 oz (113g) sliced turkey breast \n1 whole wheat wrap or tortilla \n2 tablespoons (30g) hummus \nHandful of mixed salad greens \nSliced tomatoes \nSliced cucumbers";
            menu14.beverage = "Water \nHerbal tea";
            menu14.preference = "Sprinkle of sunflower seeds for crunch \n Dijon mustard for added flavor";
            menu14.nutrition = "Calories: 300-350 \nCarbohydrates: 25-30 grams \nProtein: 20-25 grams \nFat: 10-15 grams";
            menu14.time = "11:30AM - 12:30AM";
            menus.Add(menu14);

            Menu menu15 = new Menu();
            menu15.meal = "Dinner";
            menu15.dish = "Grilled Chicken Breast with Sweet Potato and Roasted Brussels Sprouts \nIngredients: \n6 oz (170g) chicken breast, grilled \n1 medium sweet potato (150g), baked \n1 cup (150g) roasted Brussels sprouts \nOlive oil \nSalt and pepper ";
            menu15.beverage = "Water \nHerbal tea";
            menu15.preference = "Garlic and herb seasoning for the chicken \nCinnamon and nutmeg for the sweet potato";
            menu15.nutrition = "Calories: 400-450 \nCarbohydrates: 35-40 grams \nProtein: 35-40 grams \nFat: 10-15 grams";
            menu15.time = "5:30PM - 6:30PM";
            menus.Add(menu15);

            Menu menu16 = new Menu();
            menu16.meal = "Breakfast";
            menu16.dish = "Protein Pancakes \nIngredients: \n1/2 cup (40g) rolled oats \n1/2 cup (120g) cottage cheese \n2 egg whites \n1/2 teaspoon vanilla extract \nDash of cinnamon \nCooking spray or olive oil for cooking ";
            menu16.beverage = "Water \nUnsweetened almond milk \nBlack coffee";
            menu16.preference = "Fresh fruit slices for topping (such as bananas or berries) \nGreek yogurt instead of syrup";
            menu16.nutrition = "Calories: 250-300 \nCarbohydrates: 25-30 grams \nProtein: 20-25 grams \nFat: 7-10 grams";
            menu16.time = "7:00AM - 8:00AM";
            menus.Add(menu16);

            Menu menu17 = new Menu();
            menu17.meal = "Lunch";
            menu17.dish = "Quinoa and Black Bean Salad \n Ingredients \n 1/2 cup (90g) cooked quinoa\n1/2 cup (90g) canned black beans, rinsed and drained \n1/4 cup (40g) diced bell peppers \n1/4 cup (30g) diced red onion \nHandful of chopped cilantro \nJuice of 1 lime \nSalt and pepper to taste";
            menu17.beverage = "Water \nUnsweetened iced tea \nSparkling water with lemon";
            menu17.preference = "Cherry tomatoes for added flavor \nSplash of hot sauce for heat";
            menu17.nutrition = "Calories: 200-250 \nCarbohydrates: 30-35 grams \nProtein: 8-10 grams \nFat: 5-7 grams";
            menu17.time = "11:30AM - 12:30PM";
            menus.Add(menu17);

            Menu menu18 = new Menu();
            menu18.meal = "Dinner";
            menu18.dish = "Turkey and Vegetable Stir-Fry with Brown Rice \nIngredients: \n6 oz (170g) lean ground turkey \n1 cup (200g) mixed stir-fry vegetables (bell peppers, broccoli, carrots) \n1 cup (185g) cooked brown rice \nSoy sauce \nMinced garlic and ginger \nOlive oil ";
            menu18.beverage = "Iced tea with lemon \nUnsweetened almond milk";
            menu18.preference = "Sriracha or chili sauce for added flavor";
            menu18.nutrition = "Calories: 350-400 \nCarbohydrates: 35-45 grams \nProtein: 25-30 grams \nFat: 10-15 grams";
            menu18.time = "6:00PM - 7:00PM";
            menus.Add(menu18);

        }

        
    }
}
