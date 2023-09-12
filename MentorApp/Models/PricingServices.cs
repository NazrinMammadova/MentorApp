namespace MentorApp.Models
{
    public class PricingServices
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
    }
}
