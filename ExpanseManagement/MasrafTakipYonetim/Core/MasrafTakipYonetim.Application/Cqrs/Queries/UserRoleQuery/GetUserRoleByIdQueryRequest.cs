﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasrafTakipYonetim.Application.Cqrs.Queries.UserRoleQuery
{
    public class GetUserRoleByIdQueryRequest:IRequest<GetUserRoleByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
