using LeaderBoard.DAL.DataAccess.Interfaces;
using MediatR;

namespace LeaderBoard.Infrastructure.Commands.CommandHandlers
{
    public class DeleteTeamCommandHandler : IRequestHandler<DeleteTeamCommand, bool>
    {
        private readonly ITeamRepository _teamRepository;

        public DeleteTeamCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public async Task<bool> Handle(DeleteTeamCommand request, CancellationToken cancellationToken)
        {
            return await _teamRepository.DeleteCounter(request.TeamId);
        }
    }
}
