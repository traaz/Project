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
    public class MesailerController : ControllerBase
    {
        IMesaiService _mesaiService;

        public MesailerController(IMesaiService mesaiService)
        {
            _mesaiService = mesaiService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _mesaiService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Mesai mesai)
        {
            var result = _mesaiService.Add(mesai);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Mesai mesai)
        {
            var result = _mesaiService.Update(mesai);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Mesai mesai)
        {
            var result = _mesaiService.Delete(mesai);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

      
    }
}
