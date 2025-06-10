using ApplicationLayer.DTOs;
using DomainLAyer.Entities;
using MediatR;


namespace ApplicationLayer.Commandes.EmployeeCommand
{
    public class DeleteEmployeeCommande : IRequest<ServiceResponse>
    {
        public int Id { get; set; }

    }
}
