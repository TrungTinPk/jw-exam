using Examination.Application.Queries.V1.Exams.GetHomeExamList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Examination.API.Controllers.V2
{
    [Microsoft.AspNetCore.Mvc.Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class ExamsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExamsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetExamList(string sample)
        {
            var query = new GetHomeExamListQuery();
            var queryResult = await _mediator.Send(query);
            return Ok(queryResult);
        }

    }
}
