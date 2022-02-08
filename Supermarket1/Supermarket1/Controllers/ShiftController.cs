﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supermarket.BL.Interfaces;
using Supermarket.Models.DTO;
using Supermarket.Models.Request;
using Supermarket.Models.Response;

namespace Supermarket1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShiftController : ControllerBase
    {
        private readonly IShiftService _shiftService;
        private readonly IMapper _mapper;

        public ShiftController(IShiftService shiftService, IMapper mapper)
        {

            _shiftService = shiftService;
            _mapper = mapper;
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _shiftService.GetAll();


            return Ok(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            if (id <= 0) return BadRequest();

            var result = _shiftService.GetById(id);

            if (result == null) return NotFound(id);

            var response = _mapper.Map<ShiftResponse>(result);

            return Ok(response);
        }

        [HttpPost("Create")]
        public IActionResult CreateEmployee([FromBody] ShiftRequest shiftRequest)
        {
            if (shiftRequest == null) return BadRequest();

            var shift = _mapper.Map<Shift>(shiftRequest);
            var result = _shiftService.Create(shift);

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest(id);

            var result = _shiftService.Delete(id);

            if (result == null) return NotFound(id);

            return Ok(result);
        }

        [HttpPost("Update")]
        public IActionResult Update([FromBody] ShiftUpdateRequest shiftRequest)
        {
            if (shiftRequest == null) return BadRequest();

            var searchShift = _shiftService.GetById(shiftRequest.Id);

            if (searchShift == null) return NotFound(shiftRequest.Id);

            searchShift.Id = shiftRequest.Id;
            searchShift.WorkingDays = shiftRequest.workingDays;
            searchShift.Employees = shiftRequest.Employees;
            var result = _shiftService.Update(searchShift);

            return Ok(result);
        }
    }
}
