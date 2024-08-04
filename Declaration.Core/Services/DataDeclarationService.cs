using Declaration.Core.Common;
using Declaration.Core.Entities;
using Declaration.Core.Interfaces;
using Declaration.Core.Data;
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


            var testData = new TestDataDeclaration
            {
                //nroTransaccion = BigInteger.Parse(xmlDoc.Root.Element("nroTransaccion").Value),
                //fechaHoraTrn = DateTime.Parse(xmlDoc.Root.Element("fechaHoraTrn").Value),
                fechaAConsultar = xmlDoc.Root.Element("fechaAConsultar").Value,
                cuentaDeclaraciones = int.Parse(xmlDoc.Root.Element("cuentaDeclaraciones").Value),
                datosComprimidos = decompressedData
            };

            var dDT = new DDT
            {
                Iddtextr = "200023023604A",
                Cddtver = 2,
                Iddtext = "200023023604A",
                Iddt = "200023INTE027863Z",
                Iext = "5940440",
                Cddteta = "CANC",
                Dddtoficia = DateTime.Parse("2020-08-04T09:40:40"),
                Dddtrectifa = DateTime.Parse("2020-08-04T09:48:07"),
                Cddtcirvis = "A",
                Qddttaxchg = 24.6147,
                Ista = "5100",
                Cddtbur = "0023",
                Cddtburdst = "0023",
                Cddtdep = "",
                Cddtentrep = "",
                Cddtage = "14091",
                Nddtimmioe = "06826421093070",
                Lddtnomioe = "HA***O CI***S, SO*****D AN****A",
                Cddtagr = "01721159991080",
                Lddtagr = "AG****A AD*****A ES****L S. DE R.L.",
                Cddtpayori = "SV",
                Cddtpaidst = "SV",
                Lddtnomfod = "AL****S IM*******S S.A. DE C.V.",
                Cddtincote = "CIP",
                Cddtdevfob = "USD",
                Cddtdevfle = "",
                Cddtdevass = "",
                Cddttransp = "14079",
                Cddtmdetrn = "T",
                Cddtpaytrn = "SV",
                Nddtart = 1,
                Nddtdelai = 54,
                Dddtbae = DateTime.Parse("2020-08-04T11:26:25"),
                Dddtsalida = DateTime.Parse("2020-08-04T12:34:12"),
                Dddtcancel = DateTime.Parse("2021-06-20T00:29:35"),
                Dddtechean = DateTime.Parse("2025-02-04T00:00:00"),
                Cddtobs = ""
            };

            try
            {
                _applicationDbContext.Add(dDT);
                await _applicationDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException;
                while (innerException != null)
                {
                    Console.WriteLine(innerException.Message);
                    innerException = innerException.InnerException;
                }
                throw;
            }



            return testData;
        }
    }
}
