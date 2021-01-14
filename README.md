# Tax-Service
Code test

A simple WebApi client with two functions:
1. Get tax rates for a given location
2. Calculate the total tax amount for a given order.

Additional modules:
Newtonsoft.Json for JSON stuff
RestSharp for WebApi client stuff
SimpleInjector for DI

I provided a Windows forms app to demo the functionality, as well as unit tests.

The api url and token key are string contstants in TaxCalculator.cs.  In real world these can be in config file or CMS config item.

I did not include logging or complete error handling as it was not included in the instructions.

The "order" is mocked in the windows form and in the unit test.
