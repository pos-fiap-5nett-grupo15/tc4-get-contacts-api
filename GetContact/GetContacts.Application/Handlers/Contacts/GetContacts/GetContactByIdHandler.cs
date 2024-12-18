using CreateContact.Infrastructure.Services.Contact;
using FluentValidation;
using GetContacts.Application.DTOs.Contacts.GetContacts;
using MediatR;
using TechChallenge3.Domain.Entities.Contact;

namespace GetContacts.Application.Handlers.Contacts.GetContacts
{
    public class GetContactByIdHandler : IRequestHandler<GetContactsByIdRequest, GetContactsResponse>
    {
        private readonly IValidator<GetContactsByIdRequest> _validator;
        private readonly IContactService _contactService;

        public GetContactByIdHandler(
            IValidator<GetContactsByIdRequest> validator,
            IContactService contactService
            )
        {
            this._validator = validator;
            this._contactService = contactService;
        }
        public async Task<GetContactsResponse> Handle(GetContactsByIdRequest request, CancellationToken cancellationToken)
        {

            return this.Validate(request) ?? Mapper(await this._contactService.GetByIdAsync(request.Id));
        }

        public GetContactsResponse? Validate(GetContactsByIdRequest request)
        {

            var validationResult = this._validator.Validate(request);

            if (!validationResult.IsValid)
                return new GetContactsResponse() { ErrorDescription = String.Join(" ", validationResult.Errors) };
            else return null;
        }

        static public GetContactsResponse Mapper(ContactEntity? model) =>
        model is null
        ? new GetContactsResponse()//null
        : new GetContactsResponse
        {
            Id = model.Id,
            Nome = model.Nome,
            Email = model.Email,
            Ddd = model.Ddd,
            Telefone = model.Telefone,
            SituacaoAnterior = model.SituacaoAnterior?.ToString(),
            SituacaoAtual = model.SituacaoAtual?.ToString(),
        };
    }
}
