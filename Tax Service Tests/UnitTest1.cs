using NUnit.Framework;
using Tax_Service;

namespace Tax_Service_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetRates()
        {
            TaxCalculator taxCalculator = new TaxCalculator();
            var rates = taxCalculator.GetRates("32801");
            Assert.AreEqual(rates.city.ToLower(), "orlando");
        }

        [Test]
        public void CalculateTaxesForOrder()
        {
            var order = new
            {
                from_country = "US",
                from_zip = "07001",
                from_state = "NJ",
                from_city = "Avenel",
                from_street = "305 W Village Dr",
                to_country = "US",
                to_zip = "07446",
                to_state = "NJ",
                to_city = "Ramsey",
                to_street = "63 W Main St",
                amount = 16.50,
                shipping = 1.50,
                line_items = new[] {
                new {
                  id = "1",
                  quantity = 1,
                  product_tax_code = "31000",
                  unit_price = 15,
                  discount = 0
                }
              }
            };
            TaxCalculator taxCalculator = new TaxCalculator();
            var tax = taxCalculator.CalculateTaxesForOrder(order);
            Assert.AreEqual(tax, "1.09");
        }
    }
}