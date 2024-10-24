using LeaderBoard.DAL.DataAccess.Interfaces;
using LeaderBoard.DAL.Dtos;
using MediatR;

namespace LeaderBoard.Infrastructure.Commands.CommandHandlers
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, bool>
    {
        private readonly ITeamRepository _teamRepository;

        public CreateTeamCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<bool> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {

            if (request.CreateUpdateTeamDto.Id.HasValue)

                return await _teamRepository.UpdateTeamAsync(request.CreateUpdateTeamDto);
            return await _teamRepository.AddTeamAsync(new CreateUpdateTeamDto(Guid.NewGuid(), request.CreateUpdateTeamDto.Name));

        }
    }

}
