using LeaderBoard.DAL.Dtos;
using LeaderBoard.DAL.Models;
using MediatR;

namespace LeaderBoard.Infrastructure.Commands
{

   public record CreateTeamCommand(CreateUpdateTeamDto CreateUpdateTeamDto) : IRequest<bool>;
    
}
