namespace Tax_Service
{
    public class TaxService : ITaxService
    {
        private readonly ITaxCalculator _taxCalculator;

        public TaxService(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }
        
        public Rates GetRatesForLocation(string zip)
        {
            Rates rtn = null;

            rtn = _taxCalculator.GetRates(zip);

            return rtn;
        }

        public string CalculateTaxesForOrder(object order)
        {
            string rtn = "";

            rtn = _taxCalculator.CalculateTaxesForOrder(order);

            return rtn;
        }
    }
}
