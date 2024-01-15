﻿using GharKiAPI.Models;
using GharKiAPI.Models.DTO;
using GharKiAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace GharKiAPI.Controllers
{
    //[Route("api/[controller]")] yhn pr controller ki jgh naam rakh do taki bad me cahnge krne pr problem na ho 
    [Route("api/NationalPark")]
    [ApiController]
    public class NationalParkController : ControllerBase
    {
        //main end point httpPost httpGet
        private readonly INationalParkRepository _nationalParkRepository;
        private readonly Mapper _mapper;
        public NationalParkController(INationalParkRepository nationalParkRepository, mapper mapper)
        {
            _nationalParkRepository = nationalParkRepository;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult GetNationalPark()
        {

            var nationalparkdto = _nationalParkRepository.GetNationalParks().
                select(_mapper.map<NationalPark, NationalParkDTO>);
            return Ok(nationalparkdto);//200 ye ok ka code hai status code
        }
    }
}
