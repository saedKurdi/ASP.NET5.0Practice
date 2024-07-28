using aspTask2.Entities;
using aspTask2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace aspTask2.Controllers
{
    public class FastFoodController : Controller
    {
        static FastFoodsViewModel FastFoodsViewModel { get; set; } = new FastFoodsViewModel
        {
            FastFoods =
            {
                new FastFood(1, "Cheeseburger", "A juicy cheeseburger with a side of fries.", 6, 20, "/images/fastFoodImages/cheeseburger.jpg"),
                new FastFood(2, "Chicken Nuggets", "Crispy chicken nuggets served with dipping sauce.", 4, 30, "/images/fastFoodImages/chicken nuggets.jpg"),
                new FastFood(3, "Pepperoni Pizza", "Classic pepperoni pizza with melted cheese.", 18, 25, "/images/fastFoodImages/pepperoni pizza.jpg"),
                new FastFood(4, "Veggie Burger", "A healthy veggie burger loaded with fresh vegetables.", 7, 15, "/images/fastFoodImages/veggie burger.jpg"),
                new FastFood(5, "Hot-Dog", "A tasty hot dog with your choice of toppings.", 4, 10, "/images/fastFoodImages/hot dog.jpg"),
                new FastFood(6, "French Fries", "Golden crispy French fries.", 3, 5, "/images/fastFoodImages/french fries.jpg"),
                new FastFood(7, "Onion Rings", "Crispy onion rings with a savory batter.", 45, 15, "/images/fastFoodImages/onion rings.jpg"),
                new FastFood(8, "Chicken Sandwich", "Grilled chicken sandwich with lettuce and mayo.", 5, 18, "/images/fastFoodImages/chicken sandwich.jpg"),
                new FastFood(9, "Fish Tacos", "Delicious fish tacos with a tangy sauce.", 19, 22, "/images/fastFoodImages/fish tacos.jpg"),
                new FastFood(10, "Milkshake", "Rich and creamy milkshake with various flavors.", 24, 17, "/images/fastFoodImages/milkshake.jpg")

            }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(FastFoodsViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            FastFoodsViewModel.DeleteFastFoodById(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var currentFastFood = FastFoodsViewModel.FastFoods.FirstOrDefault(f => f.Id == id);
            var newFastFood = new FastFood(currentFastFood.Id,currentFastFood.Name,currentFastFood.Description,currentFastFood.Price,currentFastFood.Discount,currentFastFood.ImagePath);
            var vm = new EditFastFoodViewModel(newFastFood);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditFastFoodViewModel vm)
        {
            if (ModelState.IsValid) {
                var oldFastFood = FastFoodsViewModel.FastFoods.FirstOrDefault( f=> f.Id == vm.FastFood.Id);
                var index = FastFoodsViewModel.FastFoods.IndexOf(oldFastFood);
                FastFoodsViewModel.FastFoods[index] = vm.FastFood;
                return RedirectToAction(nameof(Index));
            }
            else return View(vm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new AddFastFoodViewModel(new FastFood());
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(AddFastFoodViewModel vm) {
            if (ModelState.IsValid) {
                vm.FastFood.Id = FastFoodsViewModel.FastFoods.Count + 1;
                FastFoodsViewModel.AddNewFastFood(vm.FastFood);
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }
    }
}
