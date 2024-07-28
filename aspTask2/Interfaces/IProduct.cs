namespace aspTask2.Interfaces
{
    public interface IProduct : IId
    {
        string Name { get; set; }
        string Description { get; set; }
        int Price { get; set; }
        int Discount { get; set; }
        string  ImagePath { get; set; }
    }
}
