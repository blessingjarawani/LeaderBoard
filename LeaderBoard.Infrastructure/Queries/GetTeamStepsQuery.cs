using MediatR;

namespace LeaderBoard.Infrastructure.Queries
{
    public record GetTeamStepsQuery(Guid TeamId) : IRequest<int>;
}
