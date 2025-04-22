using InterviewTaskWeb.ExportImport.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace InterviewTaskWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExportImportController : ControllerBase
    {
        private readonly IExportImport _exportImportService;

        public ExportImportController(IExportImport exportImportService)
        {
            _exportImportService = exportImportService;
        }

        [HttpGet("export/xml")]
        public async Task<ActionResult> ExportToXml()
        {
            var xml = await _exportImportService.ExportToXmlAsync();
            return Content(xml, "application/xml", Encoding.UTF8);
        }

        [HttpPost("import/xml")]
        public async Task<IActionResult> ImportFromXml([FromBody] string xml)
        {
            await _exportImportService.ImportFromXmlAsync(xml);
            return NoContent();
        }
    }
}