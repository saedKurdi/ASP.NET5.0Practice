using aspTask2.Entities;
namespace aspTask2.Models
{
    public class AddFastFoodViewModel
    {
        // public properties : 
        public FastFood FastFood {get;set;}

        // default constructor : 
        public AddFastFoodViewModel(){}

        // parametric constructor : 
        public AddFastFoodViewModel(FastFood fastFood)
        {
            FastFood = fastFood;
        }
    }
}
