using ApplicationLayer.Commandes.EmployeeCommand;
using ApplicationLayer.Queries.EmployeeQuery;
using DomainLAyer.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
       private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await mediator.Send(new GetEmployeeListQuery()));


        // GET BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await mediator.Send(new GetEmployeeByIdQuery { Id = id}));

        // POST
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Employee employeeDTO) => Ok(await mediator.Send(new CreateEmployeeCommand { Employee = employeeDTO })); 

        // PUT
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Employee employeeDTO) => Ok(await mediator.Send(new UpdateEmployeeCommand { Employee = employeeDTO }));

        //DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) => Ok(await mediator.Send(new DeleteEmployeeCommande { Id = id }));


    }
}
