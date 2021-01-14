using Newtonsoft.Json.Linq;

namespace Tax_Service
{
    public class Rates : IRates
    {
        public string city { get; set; }
        public string city_rate { get; set; }
        public string combined_district_rate { get; set; }
        public string combined_rate { get; set; }
        public string country { get; set; }
        public string country_rate { get; set; }
        public string county { get; set; }
        public string county_rate { get; set; }
        public string freight_taxable { get; set; }
        public string state { get; set; }
        public string state_rate { get; set; }
        public string zip { get; set; }

        public Rates(JObject jo)
        {
            city = jo["rate"]["city"].ToString();
            city_rate = jo["rate"]["city_rate"].ToString();
            combined_district_rate = jo["rate"]["combined_district_rate"].ToString();
            combined_rate = jo["rate"]["combined_rate"].ToString();
            country = jo["rate"]["country"].ToString();
            country_rate = jo["rate"]["country_rate"].ToString();
            county = jo["rate"]["county"].ToString();
            county_rate = jo["rate"]["county_rate"].ToString();
            freight_taxable = jo["rate"]["freight_taxable"].ToString();
            state = jo["rate"]["state"].ToString();
            state_rate = jo["rate"]["state_rate"].ToString();
            zip = jo["rate"]["zip"].ToString();
        }
    }
}
