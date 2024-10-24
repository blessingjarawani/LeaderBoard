namespace LeaderBoard.DAL.Dtos
{
    public record CreateEmployeeDto(Guid Id, string Name, Guid TeamId, int Steps);
}
