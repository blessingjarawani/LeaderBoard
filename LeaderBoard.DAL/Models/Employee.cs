namespace LeaderBoard.DAL.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TeamId { get; set; }
        public int StepCounts { get; set; }
    }
}
