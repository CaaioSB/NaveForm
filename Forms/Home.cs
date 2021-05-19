using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using NaveUI.Components;
using NaveForm.Common;

namespace NaveForm.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGetEmpoloyeers_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(App.ApiUrl);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(App.UrlParameters).Result;

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
