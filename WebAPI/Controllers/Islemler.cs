using Business.Abstract;
using Entities.DTOs;
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
    public class Islemler : ControllerBase
    {
        ICalisanService _calisanService;
        IAsiService _asiService;
        ICovBelirtiService _covBelirtiService;
        ICovidService _covidService;
        IHastalikService _hastalikService;
        IilacService _ilacService;
        IKronikHastalikService kronikHastalikService;
        IMesaiService _mesaiService;
        ITemasliService _temasliService;

        public Islemler(ICalisanService calisanService, IAsiService asiService, ICovBelirtiService covBelirtiService, ICovidService covidService, IHastalikService hastalikService, IilacService ilacService, IKronikHastalikService kronikHastalikService, IMesaiService mesaiService, ITemasliService temasliService)
        {
            _calisanService = calisanService;
            _asiService = asiService;
            _covBelirtiService = covBelirtiService;
            _covidService = covidService;
            _hastalikService = hastalikService;
            _ilacService = ilacService;
            this.kronikHastalikService = kronikHastalikService;
            _mesaiService = mesaiService;
            _temasliService = temasliService;
        }
        [HttpGet("5-getLisansCovid")]
        public EgitimDurumuCovidDto GetLisansCovid()
        {
            return _calisanService.GetLisanCovid();

        }
        [HttpGet("5-getYuksekLisansCovid")]
        public EgitimDurumuCovidDto GetYuksekLisansCovid()
        {
            return _calisanService.GetYuksekLisansCovid();

        }
        [HttpGet("5-getDoktoraCovid")]
        public EgitimDurumuCovidDto GetDoktoraCovid()
        {
            return _calisanService.GetDoktoraCovid();

        }
        [HttpGet("5-getLisanssizCovid")]
        public EgitimDurumuCovidDto GetLisanssizCovid()
        {
            return _calisanService.GetLisanssizCovid();

        }

        [HttpGet("6-getTop3Hastalik")]
        public IActionResult GetTopHastalik()
        {
            var result = _hastalikService.GetHastalikDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("6-getTop3HastalikCalisanlar")]
        public IActionResult GetTopHastalikCalisanlar()
        {
            var result = _hastalikService.GetHastaCalisanlarDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("7-getSehirTop3Hastaliklar")]
        public IActionResult GetSehirTopHastaliklar(string sehir)
        {
            var result = _hastalikService.GetSehirTopHastalik(sehir);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("8-getTop3Ilac")]
        public IActionResult GetTop3Ilac()
        {
            var result = _ilacService.GetTop3Ilac();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("8-getTop3IlacCalisan")]
        public IActionResult GetTop3IlacCalisan()
        {
            var result = _ilacService.GetTop3IlacCalisan();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("8-getTop3IlacCovid")]
        public IActionResult GetTop3IlacCovid()
        {
            var result = _ilacService.GetIlacCovidDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("9-getIlacCalisan")]
        public IActionResult GetIlacCalisan(string ilac)
        {
            var result = _ilacService.GetIlacCalisan(ilac);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("9-getIlacCovid")]
        public IActionResult GetCovid(string ilac)
        {
            var result = _ilacService.GetCovid(ilac);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("10-getBiontech")]
        public IActionResult GetBiontecch()
        {
            var result = _covidService.GetBiontech();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("11-getAsiCovidOrani")]
        public IActionResult GetAsiCovidOrani()
        {
            var result = _covidService.GetAsiCovid();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("12-getKronikHastalikCovid")]
        public IActionResult GetKronikHastalikCovid(string kronikHastalik)
        {
            var result = kronikHastalikService.GetKronikHastalikCovidDto(kronikHastalik);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("13-getKanGrubuCovid")]
        public IActionResult GetKanGrubuCovid()
        {
            var result = _covidService.GetKanGrubuCovid();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("14-getMesaiSaatiCovid")]
        public IActionResult GetMesaiSaatiCovid()
        {
            var result = _mesaiService.GetCalismaSaatiCovidDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("15-getTop3Belirti")]
        public IActionResult GetTop3Belirti()
        {
            var result = _covBelirtiService.GetTop3Belirti();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("16-getTop3TemasliId")]
        public IActionResult GetTop3TemasliId()
        {
            var result = _temasliService.GetTop3TemasliId();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("17-getBiontechSinovacCovid")]
        public IActionResult GetBiontechSinovacCovid()
        {
            var result = _asiService.GetBiontechSinovacCovid();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("18-getHaftaSonuCovid")]
        public IActionResult GetHaftaSonuCovid()
        {
            var result = _mesaiService.GetHaftaSonuCovidDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("19-getTop10HastalikCalisanId")]
        public IActionResult GetTop10HastalikCalisanId()
        {
            var result = _hastalikService.GetTop10HastalikCalisanId();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("19-getTop10HastalikCalisanSonBirAyCovid")]
        public IActionResult GetTop10HastalikCalisanIdSonBirAyCovid()
        {
            var result = _hastalikService.GetSonBirAyCovidDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
    }
}
