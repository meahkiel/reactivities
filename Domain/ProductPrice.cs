namespace Domain
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public string PromotionName { get; set; }
        public string PriceLevel { get; set; }
      
        public decimal PriceFactor { get; set; }
        public decimal Price { get; set; }


    }
}