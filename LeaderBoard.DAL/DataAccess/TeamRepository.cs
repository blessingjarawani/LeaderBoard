using LeaderBoard.DAL.DataAccess.Interfaces;
using LeaderBoard.DAL.Dtos;
using LeaderBoard.DAL.Models;

namespace LeaderBoard.DAL.DataAccess
{
    public class TeamRepository : ITeamRepository
    {
        private List<Team> _teams { get; set; } = new List<Team>();
        public Task<bool> AddTeamAsync(CreateUpdateTeamDto team)
        {
            _teams.Add(new Team { Id = team.Id.Value, Name = team.Name });
            return Task.FromResult(true);
        }

        public Task<bool> UpdateTeamAsync(CreateUpdateTeamDto team)
        {
            var existingTeam = _teams.FirstOrDefault(x => x.Id == team.Id);
            if (!(existingTeam is null))
            {
                existingTeam.Name = team.Name;
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<bool> IncrementStepsAsync(CounterDto counterDto)
        {
            var team = GetTeamById(counterDto.TeamId);

            if (team != null)
            {
                var employee = team.Employees.FirstOrDefault(x => x.Id == counterDto.EmployeeId);
                if (employee != null)
                {
                    employee.StepCounts += counterDto.StepCount;
                }
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task<bool> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            var team = GetTeamById(createEmployeeDto.TeamId);

            if (team != null)
            {
                var employee = team.Employees.FirstOrDefault(x => x.Id == createEmployeeDto.Id);
                if (employee != null)
                {
                    employee.StepCounts += createEmployeeDto.Steps;
                }
                else
                {
                    team.Employees.Add(new Employee
                    {
                        Name = createEmployeeDto.Name,
                        Id = Guid.NewGuid(),
                        StepCounts = createEmployeeDto.Steps,
                        TeamId = createEmployeeDto.TeamId
                    });
                }
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Team? GetTeamById(Guid teamId)
              => _teams?.FirstOrDefault(x => x.Id == teamId) ?? null;


        public Task<int> GetTeamStepsAsync(Guid teamId)
           => Task.FromResult(GetTeamById(teamId)?.TotalSteps ?? 0);


        public Task<List<TeamDto>> GetAllTeamsAsync(Guid? id)
        {
            if (id.HasValue)
                return Task.FromResult(_teams.Where(x => x.Id == id).Select(x => new TeamDto(x.Id, x.Name, x.TotalSteps)).ToList());

            return Task.FromResult(_teams.Select(x => new TeamDto(x.Id, x.Name, x.TotalSteps)).ToList());
        }

        public Task<List<EmployeeDto>> GetEmployeesCounter(Guid? teamId)
        {
           if (!teamId.HasValue)
                return Task.FromResult(_teams.SelectMany(x => x.Employees).Select(t => new EmployeeDto(t.Id, t.Name, t.StepCounts)).ToList());
            return Task.FromResult(_teams.Where(x=>x.Id== teamId.Value).SelectMany(x => x.Employees).Select(t => new EmployeeDto(t.Id, t.Name, t.StepCounts)).ToList());
        }

        public Task<bool> DeleteCounter(Guid employeeId)
        {
            var employee = _teams.SelectMany(x => x.Employees).FirstOrDefault(x => x.Id == employeeId);
            if (employee != null)
                employee.StepCounts = 0;
            return Task.FromResult(true);
        }

        public Task<bool> DeleteTeam(Guid teamId)
        {
            var team = GetTeamById(teamId);
            if (team != null)
               _teams.Remove(team);
         
            return Task.FromResult(true);
        }


    }
}