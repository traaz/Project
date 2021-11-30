using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalisanlarController : ControllerBase
    {
        ICalisanService _calisanService;

        public CalisanlarController(ICalisanService calisanService)
        {
            _calisanService = calisanService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _calisanService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Calisan calisan)
        {
            var result = _calisanService.Add(calisan);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Calisan calisan)
        {
            var result = _calisanService.Update(calisan);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Calisan calisan)
        {
            var result = _calisanService.Delete(calisan);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
