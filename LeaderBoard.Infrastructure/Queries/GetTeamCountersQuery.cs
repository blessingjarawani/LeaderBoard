using LeaderBoard.DAL.Dtos;
using MediatR;

namespace LeaderBoard.Infrastructure.Queries
{
    public record GetTeamCountersQuery(Guid? TeamId) : IRequest<IEnumerable<EmployeeDto>>;
}
