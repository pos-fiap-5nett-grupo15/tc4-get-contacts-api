using MediatR;

namespace GetContacts.Application.DTOs.Contacts.GetContacts
{
    public class GetContactsByIdRequest : IRequest<GetContactsResponse>
    {
        public int Id { get; set; }

        public GetContactsByIdRequest(int id)
        {
            this.Id = id;
        }
    }
}
