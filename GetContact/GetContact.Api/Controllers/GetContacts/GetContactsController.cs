using GetContacts.Application.DTOs.Contacts.GetContacts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TechChallenge3.Common.DTOs;

namespace GetContact.Api.Controllers.GetContacts
{
    [Controller]
    [Route("[controller]")]
    // TODO: Implementar autenticação/autorização
    public class GetContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GetContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest, type: typeof(BaseReponse))]
        public async Task<IActionResult> GetContactByIdAsync([FromRoute] int id)
        {
            return Ok(await this._mediator.Send(new GetContactsByIdRequest(id)));
        }
    }
}
