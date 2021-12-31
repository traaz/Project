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
    public class HastaliklarController : ControllerBase
    {
        IHastalikService _hastalikService;

        public HastaliklarController(IHastalikService hastalikService)
        {
            _hastalikService = hastalikService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result =_hastalikService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Hastalik hastalik)
        {
            var result = _hastalikService.Add(hastalik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Hastalik hastalik)
        {
            var result = _hastalikService.Update(hastalik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Hastalik hastalik)
        {
            var result = _hastalikService.Delete(hastalik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


      
    }
}
