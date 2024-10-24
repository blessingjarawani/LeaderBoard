using LeaderBoard.DAL.DataAccess.Interfaces;
using MediatR;

namespace LeaderBoard.Infrastructure.Commands.CommandHandlers
{
    public class CreateCounterCommandHandler : IRequestHandler<CreateCounterCommand, bool>
    {
        private readonly ITeamRepository _teamRepository;

        public CreateCounterCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<bool> Handle(CreateCounterCommand request, CancellationToken cancellationToken)
        {
            return await _teamRepository.CreateEmployee(request.CreateEmployeeDto);

        }
    }
}
