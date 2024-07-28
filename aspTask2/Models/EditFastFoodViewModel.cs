using aspTask2.Entities;
namespace aspTask2.Models
{
    public class EditFastFoodViewModel
    {
        // public properties : 
        public FastFood  FastFood { get; set; }

        // default constructor : 
        public EditFastFoodViewModel(){}

        // parametric constructor : 
        public EditFastFoodViewModel(FastFood fastFood)
        {
            FastFood = fastFood;
        }
    }
}
