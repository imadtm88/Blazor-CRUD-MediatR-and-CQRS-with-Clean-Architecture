using ApplicationLayer.DTOs;
using DomainLAyer.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Commandes.EmployeeCommand
{
    public class CreateEmployeeCommand : IRequest<ServiceResponse> //ServiceResponse the dto here !
    {
        public Employee? Employee { get; set; }
    }
}
