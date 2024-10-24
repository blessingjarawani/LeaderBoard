using LeaderBoard.DAL.Dtos;
using LeaderBoard.DAL.Models;

namespace LeaderBoard.DAL.DataAccess.Interfaces
{
    public interface ITeamRepository
    {
        Task<bool> AddTeamAsync(CreateUpdateTeamDto team);
        Task<bool> CreateEmployee(CreateEmployeeDto createEmployeeDto);
        Task<List<TeamDto>> GetAllTeamsAsync(Guid? id);
        Team? GetTeamById(Guid teamId);
        Task<int> GetTeamStepsAsync(Guid teamId);
        Task<bool> IncrementStepsAsync(CounterDto counterDto);
        Task<bool> UpdateTeamAsync(CreateUpdateTeamDto team);
        Task<List<EmployeeDto>> GetEmployeesCounter(Guid? teamId);
        Task<bool> DeleteCounter(Guid employeeId);
        Task<bool> DeleteTeam(Guid teamId);
    }
}