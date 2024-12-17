
using CreateContact.Infrastructure.Services.Contact;
using FluentValidation;
using FluentValidation.Results;
using GetContact.Api.Controllers.GetContacts;
using GetContacts.Application.DTOs.Contacts.GetContacts;
using GetContacts.Application.Handlers.Contacts.GetContacts;
using MediatR;
using Moq;
using TechChallenge3.Domain.Entities.Contact;

namespace TestesUnitarios.Controllers
{
    public class ContactsTests
    {
        private readonly GetContactByIdHandler _target;
        private readonly Mock<IValidator<GetContactsByIdRequest>> _validator;
        private readonly Mock<IContactService> _contactService;




        public ContactsTests()
        {
            this._validator = new Mock<IValidator<GetContactsByIdRequest>>();
            this._contactService = new Mock<IContactService>();



            this._target = new GetContactByIdHandler(this._validator.Object, this._contactService.Object);

        }


        [Fact]
        public async void GetByIdAsync()
        {

            this._validator.Setup(x => x.Validate(It.IsAny<GetContactsByIdRequest>())).Returns(new ValidationResult());
            this._contactService.Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(new ContactEntity());

            var result = this._target.Handle(new GetContactsByIdRequest(1), CancellationToken.None);

            Assert.NotNull(result);
        }
    }
}
