﻿using DomainLAyer.Entities;
using MediatR;

namespace ApplicationLayer.Queries.EmployeeQuery
{
    public class GetEmployeeListQuery : IRequest<List<Employee>> { };
}
