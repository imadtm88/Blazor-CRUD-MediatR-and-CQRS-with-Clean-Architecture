using ApplicationLayer.Commandes.EmployeeCommand;
using ApplicationLayer.DTOs;
using InfrastructureLayer.Data;
using MediatR;


namespace InfrastructureLayer.Handlers.EmployeeHandler
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommande, ServiceResponse>
    {
        private readonly AppDbContext appDbContext;

        public DeleteEmployeeHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<ServiceResponse> Handle(DeleteEmployeeCommande request, CancellationToken cancellationToken)
        {
            var employee = await appDbContext.Employees.FindAsync(request.Id);
            if (employee == null)
                return new ServiceResponse(false, "User not found");

            appDbContext.Employees.Remove(employee);
            await appDbContext.SaveChangesAsync();
            return new ServiceResponse(true, "Deleted");
        }
    }
}
