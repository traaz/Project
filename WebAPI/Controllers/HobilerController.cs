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
    public class HobilerController : ControllerBase
    {
        IHobiService _hobiService;

        public HobilerController(IHobiService hobiService)
        {
            _hobiService = hobiService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _hobiService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Hobii hobi)
        {
            var result = _hobiService.Add(hobi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Hobii hobi)
        {
            var result = _hobiService.Update(hobi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Hobii hobi)
        {
            var result = _hobiService.Delete(hobi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}
