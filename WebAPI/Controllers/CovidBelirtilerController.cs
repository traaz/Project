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
    public class CovidBelirtilerController : ControllerBase
    {
        ICovBelirtiService _covBelirtiService;

        public CovidBelirtilerController(ICovBelirtiService covBelirtiService)
        {
            _covBelirtiService = covBelirtiService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _covBelirtiService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(CovidBelirti covidBelirti)
        {
            var result = _covBelirtiService.Add(covidBelirti);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(CovidBelirti covidBelirti)
        {
            var result = _covBelirtiService.Update(covidBelirti);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(CovidBelirti covidBelirti)
        {
            var result = _covBelirtiService.Delete(covidBelirti);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getTop3Belirti")]
        public IActionResult GetTop3Belirti()
        {
            var result = _covBelirtiService.GetTop3Belirti();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
    }
}
