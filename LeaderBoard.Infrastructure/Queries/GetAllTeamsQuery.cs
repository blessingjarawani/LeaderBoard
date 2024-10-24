using LeaderBoard.DAL.Dtos;
using MediatR;

namespace LeaderBoard.Infrastructure.Queries
{
    public record GetAllTeamsQuery(Guid? TeamId) : IRequest<IEnumerable<TeamDto>>;
}
