using MediatR;

namespace LeaderBoard.Infrastructure.Commands
{
    public record DeleteCounterCommand(Guid employeeId) : IRequest<bool>;
}
