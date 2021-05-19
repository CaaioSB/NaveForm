using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using NaveUI.Components;

namespace NaveForm.Forms
{
    public partial class Home : Form
    {
        private const string apiUrl = "http://my-json-server.typicode.com/caaiosb/naveform/employeers";
        private string urlParameters = "?";

        public Home()
        {
            InitializeComponent();
        }

        public class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public string role{ get; set; }
            public string src { get; set; }
        }

        private void btnGetEmpoloyeers_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiUrl);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;

            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;

                foreach (var employee in dataObjects)
                {
                    naveEmployee emp = new naveEmployee();
                    emp.EmployeeName = employee.name;
                    emp.EmployeeRole = employee.role;

                    if (!String.IsNullOrWhiteSpace(employee.src))
                    {
                        emp.EmployeePhotoUrl = employee.src;
                    }

                    flowLayoutPanel1.Controls.Add(emp);
                }
            }
        }
    }
}
