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
    public class IlaclarController : ControllerBase
    {
        IilacService _ilacService;

        public IlaclarController(IilacService ilacService)
        {
            _ilacService = ilacService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _ilacService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Ilac ilac)
        {
            var result = _ilacService.Add(ilac);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Ilac ilac)
        {
            var result = _ilacService.Update(ilac);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Ilac ilac)
        {
            var result = _ilacService.Delete(ilac);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getTop3Ilac")]
        public IActionResult GetTop3Ilac()
        {
            var result = _ilacService.GetTop3Ilac();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getTop3IlacCovid")]
        public IActionResult GetIlacCovid()
        {
            var result = _ilacService.GetIlacCovidDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getCovid")]
        public IActionResult GetCovid(string sehir)
        {
            var result = _ilacService.GetCovid(sehir);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
    }
}
