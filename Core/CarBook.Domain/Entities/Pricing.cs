namespace CarBook.Domain.Entities
{
    public class Pricing
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
        public List<CarPricing> CarPricing { get; set; }
    }
}
