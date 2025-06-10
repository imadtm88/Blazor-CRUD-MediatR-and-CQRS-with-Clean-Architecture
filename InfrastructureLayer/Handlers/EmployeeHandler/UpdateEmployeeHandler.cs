using ApplicationLayer.Commandes.EmployeeCommand;
using ApplicationLayer.DTOs;
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
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, ServiceResponse>
    {
        private readonly AppDbContext appDbContext;

        public UpdateEmployeeHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<ServiceResponse> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            appDbContext.Update(request.Employee);
            await appDbContext.SaveChangesAsync();
            return new ServiceResponse(true, "Updated");
        }
    }
}
