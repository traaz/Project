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
    public class KronikHastaliklarController : ControllerBase
    {
        IKronikHastalikService kronikHastalikService;

        public KronikHastaliklarController(IKronikHastalikService kronikHastalikService)
        {
            this.kronikHastalikService = kronikHastalikService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = kronikHastalikService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(KronikHastalik kronikHastalik)
        {
            var result = kronikHastalikService.Add(kronikHastalik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(KronikHastalik kronikHastalik)
        {
            var result = kronikHastalikService.Update(kronikHastalik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(KronikHastalik kronikHastalik)
        {
            var result = kronikHastalikService.Delete(kronikHastalik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getKronikHastalikCovid")]
        public IActionResult GetKronikHastalikCovid(string kronikHastalik)
        {
            var result = kronikHastalikService.GetKronikHastalikCovidDto(kronikHastalik);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
    }
}
