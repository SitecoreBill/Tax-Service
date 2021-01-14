using RestSharp;
using Newtonsoft.Json.Linq;
using System;

namespace Tax_Service
{
    public class TaxCalculator : ITaxCalculator
    {
        private const string _apiUrl = "https://api.taxjar.com/v2/";
        private const string _apiKey = "5da2f821eee4035db4771edab942a4cc";
        private RestClient _client;

        public TaxCalculator()
        {
            _client = new RestClient(_apiUrl);
        }
               
        public Rates GetRates(string zipcode)
        {
            Rates rtn = null;
            var path = "rates/" + zipcode;
            try
            {
                var request = new RestRequest(path, Method.GET);
                request.AddHeader("Authorization", "Bearer " + _apiKey);
                var rtnJson = _client.Get(request).Content;
                var jo = JObject.Parse(rtnJson);
                rtn = new Rates(jo);
            }
            catch (Exception ex)
            {
                // log the exception
            }
            return rtn;
        }

        public string CalculateTaxesForOrder(object order)
        {
            var rtn = "";
            var path = "taxes";
            try
            {
                var request = new RestRequest(path, Method.POST);
                request.AddHeader("Authorization", "Bearer " + _apiKey);
                request.AddJsonBody(order);
                var rtnJson = _client.Post(request).Content;
                var jo = JObject.Parse(rtnJson);
                rtn = jo["tax"]["amount_to_collect"].ToString();
            }
            catch (Exception ex)
            {
                // log the exception
            }
            return rtn;
        }
    }
}
