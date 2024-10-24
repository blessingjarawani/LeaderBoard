using LeaderBoard.DAL.DataAccess.Interfaces;
using LeaderBoard.DAL.Dtos;

using MediatR;

namespace LeaderBoard.Infrastructure.Queries.QueryHandlers
{
    public class GetAllTeamsQueryHandler : IRequestHandler<GetAllTeamsQuery, IEnumerable<TeamDto>>
    {
        private readonly ITeamRepository _teamRepository;

        public GetAllTeamsQueryHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<IEnumerable<TeamDto>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
        {
            var result = await _teamRepository.GetAllTeamsAsync(request.TeamId);
            return result;
        }
    }
}
