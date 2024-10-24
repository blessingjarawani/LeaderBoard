namespace LeaderBoard.DAL.Models
{

    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TotalSteps => Employees.Sum(x => x.StepCounts);
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }

}
