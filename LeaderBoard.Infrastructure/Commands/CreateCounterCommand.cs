using LeaderBoard.DAL.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaderBoard.Infrastructure.Commands
{
    public record CreateCounterCommand(CreateEmployeeDto CreateEmployeeDto) : IRequest<bool>;
}
