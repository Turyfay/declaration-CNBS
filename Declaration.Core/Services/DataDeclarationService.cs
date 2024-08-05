using Declaration.Core.Common;
using Declaration.Core.Entities;
using Declaration.Core.Interfaces;
using Declaration.Core.Data;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Declaration.Core.Services
{
    public class DataDeclarationService : IDataDeclarationService
    {

        private readonly HttpClient _httpClient;
        private readonly ApplicationDbContext _applicationDbContext;

        public DataDeclarationService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
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

            string compressedData = xmlDoc.Root.Element("datosComprimidos").Value;
            string decompressedData = await JsonTextDeclarationHelpe.DecompressAsync(compressedData);


            var testDataDeclaration = new TestDataDeclaration
            {
                //nroTransaccion = BigInteger.Parse(xmlDoc.Root.Element("nroTransaccion").Value),
                //fechaHoraTrn = DateTime.Parse(xmlDoc.Root.Element("fechaHoraTrn").Value),
                fechaAConsultar = xmlDoc.Root.Element("fechaAConsultar").Value,
                cuentaDeclaraciones = int.Parse(xmlDoc.Root.Element("cuentaDeclaraciones").Value),
                datosComprimidos = "OK"
            };

            List<DataDeclaration>? oDataDeclarations = JsonConvert.DeserializeObject<List<DataDeclaration>>(decompressedData);
            List<DDT> ddtEntities = new List<DDT>();
            List<LIQ> liqEntities = new List<LIQ>();
            List<LQA> lqaEntities = new List<LQA>();
            List<ART> artEntities = new List<ART>();
            if (oDataDeclarations != null && oDataDeclarations.Count > 0)
            {
                foreach (DataDeclaration itemDeclaration in oDataDeclarations)
                {
                    
                    ddtEntities.Add(itemDeclaration.DDT);
                    liqEntities.Add(itemDeclaration.LIQ);
                    if(itemDeclaration.ART != null)
                    {
                        artEntities.AddRange(itemDeclaration.ART);
                    }
                    if (itemDeclaration.LQA != null)
                    {
                        lqaEntities.AddRange(itemDeclaration.LQA);
                    }
                }
            }
            await _applicationDbContext.DDTs.AddRangeAsync(ddtEntities);
            await _applicationDbContext.LIQs.AddRangeAsync(liqEntities);
            await _applicationDbContext.ARTs.AddRangeAsync(artEntities);
            await _applicationDbContext.LQAs.AddRangeAsync(lqaEntities);
            await _applicationDbContext.SaveChangesAsync();

            return testDataDeclaration;
        }
    }
}
