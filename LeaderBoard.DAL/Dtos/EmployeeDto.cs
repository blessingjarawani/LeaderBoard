using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaderBoard.DAL.Dtos
{
    public record EmployeeDto(Guid Id , string Name, int Steps);
  
}
