using LeaderBoard.DAL.DataAccess.Interfaces;
using MediatR;

namespace LeaderBoard.Infrastructure.Queries.QueryHandlers
{
    public class GetTeamStepsQueryHandler : IRequestHandler<GetTeamStepsQuery, int>
    {
        private readonly ITeamRepository _teamRepository;

        public GetTeamStepsQueryHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<int> Handle(GetTeamStepsQuery request, CancellationToken cancellationToken)
             => await _teamRepository.GetTeamStepsAsync(request.TeamId);
    }

}
