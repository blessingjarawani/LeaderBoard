using LeaderBoard.Infrastructure.Commands;
using LeaderBoard.Infrastructure.Queries;
using LeaderBoard.Infrastructure.Queries.QueryHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LeaderBoard.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeamsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Commands (write operations)
        [HttpPost("[action]")]
        [SwaggerOperation(Summary = "Create or Update a Team", Description = "Creates a new team or updates an existing team.")]
        [SwaggerResponse(200, "Team successfully created or updated")]
        public async Task<IActionResult> CreateOrUpdateTeam([FromQuery] CreateTeamCommand teamCommand)
        {
            var team = await _mediator.Send(teamCommand);
            return Ok(team);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCounter([FromQuery] CreateCounterCommand createCounterCommand)
        {
            var counter = await _mediator.Send(createCounterCommand);
            return Ok(counter);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> IncrementCounter([FromQuery] IncrementCounterCommand incrementCounterCommand)
        {
            var updatedCount = await _mediator.Send(incrementCounterCommand);
            return Ok(updatedCount);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetTeamTotalSteps([FromQuery] GetTeamCountersQuery getTeamCountersQuery)
        {
            var teams = await _mediator.Send(getTeamCountersQuery);
            return Ok(teams);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetTeamSteps([FromQuery] GetAllTeamsQuery getAllTeamsQuery)
        {
            var teams = await _mediator.Send(getAllTeamsQuery);
            return Ok(teams);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteTeam([FromQuery] DeleteTeamCommand deleteTeamCommand)
        {
            var teams = await _mediator.Send(deleteTeamCommand);
            return Ok(teams);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteCounter([FromQuery] DeleteCounterCommand deleteCounterCommand)
        {
            var totalSteps = await _mediator.Send(deleteCounterCommand);
            return Ok(totalSteps);
        }

      
    }
}
