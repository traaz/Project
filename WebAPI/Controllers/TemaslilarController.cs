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
    public class TemaslilarController : ControllerBase
    {
        ITemasliService _temasliService;

        public TemaslilarController(ITemasliService temasliService)
        {
            _temasliService = temasliService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _temasliService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Temasli temasli)
        {
            var result = _temasliService.Add(temasli);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Put(Temasli temasli)
        {
            var result = _temasliService.Update(temasli);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Temasli temasli)
        {
            var result = _temasliService.Delete(temasli);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
