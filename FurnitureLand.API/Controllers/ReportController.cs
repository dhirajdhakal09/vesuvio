using FurnitureLand.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureLand.API.Controllers
{
    [Route("api/report")]
    public class ReportController : BaseController
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost]
        [Route("generatereport")]
        public async Task<IActionResult> GenerateReportAsync(Guid customerId)
        {
            var reportService = await _reportService.GenerateReportAsync(customerId);
            if (reportService != null) return Ok(reportService);
            else return BadRequest();
        }
    }
}
