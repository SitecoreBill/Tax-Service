using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tax_Service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            GetTaxRate();
            Cursor = Cursors.Default;
        }

        public void GetTaxRate()
        {
            var zip = txtZip.Text;
            if (string.IsNullOrWhiteSpace(zip))
            {
                MessageBox.Show("Please enter a zip code.");
                return;
            }

            var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            if ((!Regex.Match(zip, _usZipRegEx).Success) && (!Regex.Match(zip, _caZipRegEx).Success))
            {
                MessageBox.Show("The zip code entered is not valid.");
                return;
            }
 
            var service = Program.container.GetInstance<ITaxService>();
            var rate = service.GetRatesForLocation(zip);
            var rates = new List<Rates>();
            rates.Add(rate);
            dgvRate.DataSource = rates;
        }

        public void GetTaxesForOrder()
        {
            txtTaxForOrder.Text = "";
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
            var service = Program.container.GetInstance<ITaxService>();
            txtTaxForOrder.Text = service.CalculateTaxesForOrder(order);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            GetTaxesForOrder();
            Cursor = Cursors.Default;
        }
    }
}
