using GetContacts.Application.DTOs.Contacts.GetContacts;
using FluentValidation;

namespace ContactsManagement.Application.DTOs.Validations
{
    public class GetContactByIdValidation : AbstractValidator<GetContactsByIdRequest>
    {
        public GetContactByIdValidation()
        {
            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
