using LeaderBoard.DAL.DataAccess.Interfaces;
using LeaderBoard.DAL.Dtos;
using MediatR;

namespace LeaderBoard.Infrastructure.Queries.QueryHandlers
{
    public class GetTeamCountersQueryHandler : IRequestHandler<GetTeamCountersQuery, IEnumerable<EmployeeDto>>
    {
        private readonly ITeamRepository _teamRepository;

        public GetTeamCountersQueryHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<IEnumerable<EmployeeDto>> Handle(GetTeamCountersQuery request, CancellationToken cancellationToken)
        => await _teamRepository.GetEmployeesCounter(request.TeamId);
    }
}
