using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveForm.Common
{
    public class App
    {
        private static string _apiUrl = "http://my-json-server.typicode.com/caaiosb/naveform/employeers";
        private static string _urlParameters = "?";

        public static string ApiUrl { get => _apiUrl; set => _apiUrl = value; }
        public static string UrlParameters { get => _urlParameters; set => _urlParameters = value; }
    }
}
