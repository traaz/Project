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
    public class DozlarController : ControllerBase
    {
        IDozService _dozService;

        public DozlarController(IDozService dozService)
        {
            _dozService = dozService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _dozService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Dozz doz)
        {
            var result = _dozService.Add(doz);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Dozz doz)
        {
            var result = _dozService.Update(doz);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Dozz doz)
        {
            var result = _dozService.Delete(doz);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





    }
}
