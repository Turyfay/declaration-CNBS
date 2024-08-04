using Declaration.Core.Entities;
using Declaration.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeclarationExtractorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataDeclarationController : ControllerBase
    {
        private readonly IDataDeclarationService _dataDeclarationService;

        public DataDeclarationController(IDataDeclarationService dataDeclarationService) { 
            _dataDeclarationService = dataDeclarationService;
        }

        [HttpGet("{fecha}")]
        public async Task<IActionResult> GetDataDeclaration(string fecha)
        {
            TestDataDeclaration dataDeclaration = await _dataDeclarationService.GetTestDataDeclarationAsync(fecha);
            if(dataDeclaration == null)
            {
                return NotFound();
            }
            return Ok(dataDeclaration);
        }
    }
}
