using MyIndustry.Interfaces;

namespace MyIndustry.Model
{
    public abstract class Product : IProduct
    {
        public string Title { get; }
        public int TimeCosts { get; }
        public int CostPrice { get; }
        
        public Product(string title,int timeCosts, int price)
        {
            Title = title;
            TimeCosts = timeCosts;
            CostPrice = price;
        }


    }
}
