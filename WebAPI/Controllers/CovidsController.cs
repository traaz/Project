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
    public class CovidsController : ControllerBase
    {
        ICovidService _covidService;

        public CovidsController(ICovidService covidService)
        {
            _covidService = covidService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _covidService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Covid covid)
        {
            var result = _covidService.Add(covid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Covid covid)
        {
            var result = _covidService.Update(covid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Covid covid)
        {
            var result = _covidService.Delete(covid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getBiontech")]
        public IActionResult GetBiontecch()
        {
            var result = _covidService.GetBiontech();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getKanGrubuCovid")]
        public IActionResult GetKanGrubuCovid()
        {
            var result = _covidService.GetKanGrubuCovid();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
    }
}
