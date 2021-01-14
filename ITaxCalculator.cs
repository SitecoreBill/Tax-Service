namespace Tax_Service
{
    public interface ITaxCalculator
    {
        Rates GetRates(string zipcode);

        string CalculateTaxesForOrder(object order);
    }
}
