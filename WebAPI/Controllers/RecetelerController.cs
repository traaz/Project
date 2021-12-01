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
    public class RecetelerController : ControllerBase
    {
        IReceteService _receteService;

        public RecetelerController(IReceteService receteService)
        {
            _receteService = receteService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _receteService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Recete recete)
        {
            var result = _receteService.Add(recete);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Recete recete)
        {
            var result = _receteService.Update(recete);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Recete recete)
        {
            var result = _receteService.Delete(recete);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
