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
    public class AsilarController : ControllerBase
    {
        IAsiService _asiService;

        public AsilarController(IAsiService asiService)
        {
            _asiService = asiService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _asiService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Asi asi)
        {
            var result = _asiService.Add(asi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Asi asi)
        {
            var result = _asiService.Update(asi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Asi asi)
        {
            var result = _asiService.Delete(asi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
