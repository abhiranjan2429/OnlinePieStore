namespace FoodOrderingApp.Models
{
    public interface IPayment
    {
        decimal TotalAmount { get; set; }
        decimal GetDiscountedPrince(decimal discountPercent, decimal totalBill);
    }
}