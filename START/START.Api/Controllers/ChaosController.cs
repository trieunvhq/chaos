using Microsoft.AspNetCore.Mvc;
using START.Api.Database;
using START.Api.Models;
using START.Application.MSinhVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace START.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaosController : ControllerBase
    {
        // GET: api/<ChaosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ChaosController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 1)
            {
                clsThin cls = new clsThin();
                DataTable dt = cls.T_NhanSu_tbBoPhan_SA();
                List<NhanSuModel> Lst_ns = new List<NhanSuModel>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanSuModel ns = new NhanSuModel();
                    ns.ID_BoPhan = Convert.ToInt32(dt.Rows[i]["ID_BoPhan"].ToString());
                    ns.TenBoPhan = dt.Rows[i]["TenBoPhan"].ToString();
                    ns.soluong = Convert.ToDouble(dt.Rows[i]["soluong"].ToString());
                    Lst_ns.Add(ns);
                }

                return Ok(Lst_ns);
            }
            else
                return PhysicalFile(@"C:\Socola05\\img\\1.jpg", "image/jpg");
        }

        // POST api/<ChaosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChaosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChaosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
