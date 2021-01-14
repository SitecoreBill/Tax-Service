namespace Tax_Service
{
    public interface ITaxService
    {
        Rates GetRatesForLocation(string zip);
        string CalculateTaxesForOrder(object order);
    }
}
