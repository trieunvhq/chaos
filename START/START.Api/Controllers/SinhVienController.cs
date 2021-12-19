using Microsoft.AspNetCore.Mvc;
using START.Application.MSinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace START.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly iSinhVienService _sinhVienService;

        public SinhVienController(iSinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }
        // GET: api/<SinhVienController>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _sinhVienService.GetAll());
        }

        // POST: api/<SinhVienController>/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] SinhVienRequest request)
        {
            var status = await _sinhVienService.Create(request);

            return Ok(status);
        }

        // POST: api/<SinhVienController>/Delete
        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] SinhVienRequest request)
        {
            var status = await _sinhVienService.Delete(request);

            return Ok(status);
        }

        // POST: api/<SinhVienController>/Update
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] SinhVienRequest request)
        {
            var status = await _sinhVienService.Update(request);

            return Ok(status);
        }
    }
}
