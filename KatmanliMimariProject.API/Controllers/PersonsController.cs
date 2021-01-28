
using AutoMapper;
using KatmanliMimariProject.API.DTOs;
using KatmanliMimariProject.Core.Entity;
using KatmanliMimariProject.Core.Repositories.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatmanliMimariProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Person> _personService;
        public PersonsController(IService<Person> personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
    
            var person = await _personService.GetAllAsync();
            return Ok(person);
        }
        [HttpPost]
        public async Task<IActionResult> Save(PersonDto personDto)
        {
            var newPerson = await _personService.AddAsync(_mapper.Map<Person>(personDto));
            return Created(string.Empty, _mapper.Map<PersonDto>(newPerson));
        }
    }
}
