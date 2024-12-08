using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetContacts.Application.DTOs.Contacts.GetContacts
{
    public class GetContactsRequest : IRequest<GetContactsRequest>
    {
        public GetContactsRequest(int ddd)
        {
            Ddd = ddd;
        }

        public int Ddd { get; }
    }
}
