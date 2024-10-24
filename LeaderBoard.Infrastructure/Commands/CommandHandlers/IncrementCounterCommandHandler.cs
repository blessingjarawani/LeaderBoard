using LeaderBoard.DAL.DataAccess.Interfaces;
using MediatR;

namespace LeaderBoard.Infrastructure.Commands.CommandHandlers
{
    public class IncrementCounterCommandHandler : IRequestHandler<IncrementCounterCommand, bool>
    {
        private readonly ITeamRepository _teamRepository;

        public IncrementCounterCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<bool> Handle(IncrementCounterCommand request, CancellationToken cancellationToken)
        {
            return await _teamRepository.IncrementStepsAsync(request.CounterDto);
        }
    }
}
