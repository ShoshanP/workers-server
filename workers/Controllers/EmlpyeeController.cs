using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using worker.API.Models;
using Worker.Core.DTOs;
using Worker.Core.Models;
using Worker.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace worker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmlpyeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmlpyeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        // GET: api/<EmlpyeeController>
        [HttpGet]
        public async Task<ActionResult> Get() {
            var employees = await _employeeService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employees));
        }


        // GET api/<EmlpyeeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
           return Ok(_mapper.Map<EmployeeDto>(employee));
        }


        // POST api/<EmlpyeeController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeePostModel value) =>
            Ok(_mapper.Map<EmployeeDto>(await _employeeService
                .AddAsync(_mapper.Map<Employee>(value))));


        // PUT api/<EmlpyeeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EmployeePostModel value)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee is null)
            {
                return NotFound();
            }
            _mapper.Map(value, employee);
            return Ok(_mapper.Map<EmployeeDto>(await _employeeService.
                UpdateAsync(_mapper.Map<Employee>(employee))));
        }

        // DELETE api/<EmlpyeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _employeeService.DeleteAsync(id);
            return NoContent();

        }
    }
}
