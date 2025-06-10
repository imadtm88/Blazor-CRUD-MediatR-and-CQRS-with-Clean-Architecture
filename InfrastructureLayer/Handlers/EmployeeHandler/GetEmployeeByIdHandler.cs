using ApplicationLayer.Queries.EmployeeQuery;
using DomainLAyer.Entities;
using InfrastructureLayer.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Handlers.EmployeeHandler
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly AppDbContext appDbContext;

        public GetEmployeeByIdHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken) => await appDbContext.Employees.FindAsync(request.Id);
    }
}
