using GetContacts.Application.DTOs.Contacts.GetContacts;
using FluentValidation;

namespace ContactsManagement.Application.DTOs.Validations
{
    public class GetContactsValidation : AbstractValidator<GetContactsRequest>
    {
        public GetContactsValidation()
        {
            RuleFor(c => c.Ddd)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
