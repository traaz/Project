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
    public class SemptonlarController : ControllerBase
    {
        ISemptonService _semptonService;

        public SemptonlarController(ISemptonService semptonService)
        {
            _semptonService = semptonService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _semptonService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Sempton sempton)
        {
            var result = _semptonService.Add(sempton);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Sempton sempton)
        {
            var result = _semptonService.Update(sempton);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Sempton sempton)
        {
            var result = _semptonService.Delete(sempton);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }






    }
}
