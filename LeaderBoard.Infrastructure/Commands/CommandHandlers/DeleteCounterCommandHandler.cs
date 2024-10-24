using LeaderBoard.DAL.DataAccess.Interfaces;
using MediatR;

namespace LeaderBoard.Infrastructure.Commands.CommandHandlers
{
    public class DeleteCounterCommandHandler : IRequestHandler<DeleteCounterCommand, bool>
    {
        private readonly ITeamRepository _teamRepository;

        public DeleteCounterCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<bool> Handle(DeleteCounterCommand request, CancellationToken cancellationToken)
        {
            return await _teamRepository.DeleteCounter(request.employeeId);
        }
    }
}
