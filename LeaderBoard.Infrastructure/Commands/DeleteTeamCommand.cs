using MediatR;

namespace LeaderBoard.Infrastructure.Commands
{
    public record DeleteTeamCommand(Guid TeamId) : IRequest<bool>;
}
