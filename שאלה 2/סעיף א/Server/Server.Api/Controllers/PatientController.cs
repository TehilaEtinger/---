using Microsoft.AspNetCore.Mvc;
using Server.Repository.Entities;
using Services.Interfaces;
using Services.Models;
using Services.ServiceClasses;

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        IPatientService _userService;
        public PatientController(IPatientService service)
        {
            _userService = service;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<PatientModel>> Get()
        {
            var result = await _userService.GetAllAsync();
            return result;
        }

        // GET api/<UsersController>/id
        [HttpGet("{id}")]
        public async Task<PatientModel> GetByIdNumber(int id)
        {
            return await  _userService.GetByIdNumberAsync(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<PatientModel> Post(PatientModel user)
        { 
            return await _userService.AddAsync(user);
        }

    }
}
