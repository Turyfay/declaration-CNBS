using Declaration.Core.Entities;
using Declaration.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Declaration.Core.Services
{
    public class DataDeclarationService : IDataDeclarationService
    {

        private readonly HttpClient _httpClient;

        public DataDeclarationService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://iis-des.cnbs.gob.hn/ws.TestData/")
            };
            _httpClient.DefaultRequestHeaders.Add("ApiKey", "MEYwMEJGQ0E3QUNDN0MxNTg2M0UyOEE1QTU0MTcwM0FBQjUwNjE4MkFGNjQ0RjMyQUNCMDI1OTdDMjUwMDREOA==");
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/xml");
        }

        public async Task<TestDataDeclaration> GetTestDataDeclarationAsync(string requestParameter)
        {

            string url = $"api/data?Fecha={requestParameter}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string xmlContent = await response.Content.ReadAsStringAsync();
            XDocument xmlDoc = XDocument.Parse(xmlContent);

            var testData = new TestDataDeclaration
            {
                //nroTransaccion = BigInteger.Parse(xmlDoc.Root.Element("nroTransaccion").Value),
                //fechaHoraTrn = DateTime.Parse(xmlDoc.Root.Element("fechaHoraTrn").Value),
                fechaAConsultar = xmlDoc.Root.Element("fechaAConsultar").Value,
                cuentaDeclaraciones = int.Parse(xmlDoc.Root.Element("cuentaDeclaraciones").Value),
                datosComprimidos = xmlDoc.Root.Element("datosComprimidos").Value
            };

            return testData;
        }
    }
}
