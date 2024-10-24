using LeaderBoard.DAL.Dtos;
using MediatR;

namespace LeaderBoard.Infrastructure.Commands
{
    public record IncrementCounterCommand(CounterDto CounterDto) : IRequest<bool>;
}
